using SQl_SCanner.Scanne;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace SQl_SCanner
{
    public partial class MainForm : Form
    {
        #region Form Load Event
        public MainForm()
        {
            InitializeComponent();
            MaximizedBounds = Screen.GetWorkingArea(this);
            Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            GlobalVar.form = this;
            splitContainer11.FixedPanel = FixedPanel.Panel2;
            splitContainer5.FixedPanel = FixedPanel.Panel1;
            splitContainer4.FixedPanel = FixedPanel.Panel1;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer7.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Panel2Collapsed = true;
            splitContainer2.Panel2.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //http://dotnetcodr.com/2014/01/01/5-ways-to-start-a-task-in-net-c//
            UpInfos();
            setIP();
        }
        public string monip = "N/A";
        public void setIP()
        {
            Thread th = new Thread(() =>
            {
                try
                {
                    HttpRequete hr = new HttpRequete();
                    string page = hr.get("http://checkip.dyndns.org");
                    string ip = page.Split(new string[] { "Address:", "</body>" }, StringSplitOptions.RemoveEmptyEntries)[1];
                    monip = ip;
                    statusStrip1.Invoke((MethodInvoker)(() =>
                    {
                        txt_monip.Text = "IP: " + ip;
                    }));
                }
                catch (Exception) { }
            });
            th.Start();
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            enrgistreDonne();
            Environment.Exit(0);
        } 
        #endregion

        #region Enrgistreur Remetteur

        private string ds = "DONNE";
        private string sp = "|";
        internal void remetDonne()
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            bool existe = Directory.Exists(ds);
            if (existe)
            {
                SetListView(ds + "/urls.txt", list_url);
                SetListView(ds + "/vulnerables.txt", list_vulne);
                SetListView(ds + "/injectables.txt", list_injectables);
                SetListView(ds + "/non-vulnerables.txt", list_non_vulne);
                SetListView(ds + "/trashs.txt", list_url_trash);
                SetListView(ds + "/urls_ports_open.txt", list_scanne_port);
            }
            if (!existe)
            {
                Directory.CreateDirectory(ds);
            }

            Thread th = new Thread(() =>
            {
                addListViewHashtable(list_url);
                addListViewHashtable(list_injectables);
                addListViewHashtable(list_vulne);
            });
            th.Start();
            Thread th2 = new Thread(() =>
            {
                addListViewHashtable(list_non_vulne);
                addListViewHashtable(list_url_trash);
            });
            th2.Start();
            UpInfos();
        }
        private void enrgistreDonne()
        {
            SaveListView(ds + "/urls.txt", list_url);
            SaveListView(ds + "/vulnerables.txt", list_vulne);
            SaveListView(ds + "/injectables.txt", list_injectables);
            SaveListView(ds + "/non-vulnerables.txt", list_non_vulne);
            SaveListView(ds + "/trashs.txt", list_url_trash);
            SaveListView(ds + "/urls_ports_open.txt", list_scanne_port);
        }
        private void SaveListView(string chemin, ListView lv)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            List<string> liste = new List<string> { };
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    foreach (ListViewItem lvi in lv.Items)
                    {
                        string groupe = "";
                        for (int i = 0; i < lvi.SubItems.Count; i++)
                        {
                            if (i == lvi.SubItems.Count - 1)
                                groupe += lvi.SubItems[i].Text;
                            else
                                groupe += lvi.SubItems[i].Text + sp;
                        }
                        liste.Add(groupe);
                    }
                });
                return;
            }
            else
            {
                foreach (ListViewItem lvi in lv.Items)
                {
                    string groupe = "";
                    for (int i = 0; i < lvi.SubItems.Count; i++)
                    {
                        if (i == lvi.SubItems.Count - 1)
                            groupe += lvi.SubItems[i].Text;
                        else
                            groupe += lvi.SubItems[i].Text + sp;
                    }
                    liste.Add(groupe);
                }
            }
            File.WriteAllLines(chemin, liste);
            UpInfos();
        }
        private void SetListView(string chemin, ListView lv)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            if (File.Exists(chemin))
            {
                List<string> liste = new List<string> { };
                liste.AddRange(File.ReadAllLines(chemin));
                lv.BeginUpdate();
                foreach (string element in liste)
                {
                    string[] morceaux = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(element)).Split(new string[] { sp }, StringSplitOptions.None);
                    if (!existDeja(morceaux[0], lv))
                    {
                        lv.Items.Add(new ListViewItem(morceaux));
                    }
                }
                lv.EndUpdate();
            }
        }
        private bool existDeja(string str, ListView lv)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.SubItems[0].Text == str)
                {
                    return true;
                }
            }
            return false;
        }
        public void addListViewHashtable(ListView lv)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                string url = lvi.SubItems[0].Text;
                string key = nomdomaine(url);
                try
                {
                    if (!Hashurls.Contains(key))
                    {
                        Hashurls.Add(key, url);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur: cle" + key + "\r\n URL:" + url);
                }
            }
        }

        #endregion

        internal void UpInfos()
        {
            try
            {
                list_url.Invoke((MethodInvoker)(() =>
                {
                    txt_nbr_trouver.Text = list_url.Items.Count.ToString();
                }));
                list_injectables.Invoke((MethodInvoker)(() =>
                {
                    txt_nbr_injectable.Text = list_injectables.Items.Count.ToString();
                }));
                list_vulne.Invoke((MethodInvoker)(() =>
                {
                    txt_nbr_vulne.Text = list_vulne.Items.Count.ToString();
                }));
                list_non_vulne.Invoke((MethodInvoker)(() =>
                {
                    txt_nbr_nonVulne.Text = list_non_vulne.Items.Count.ToString();
                }));
                list_scanne_port.Invoke((MethodInvoker)(() =>
                {
                    txt_nbr_scannePort.Text = list_scanne_port.Items.Count.ToString();
                }));
            }
            catch (Exception){}
        }
        public Hashtable Hashurls = new Hashtable();

        #region Tout les Thread Controlleur
            public Thread Thread_Recherche;
            public Thread Thread_scanne;
            public Thread Thread_scannePort;
            public Thread Thread_analyse;
            public Thread Thread_analyseUrls;
            public Thread Thread_Dumper;
        #endregion

        #region Recherche URL

        private void recherche_btn_Click(object sender, EventArgs e)
        {
            Outils outille = new Outils();
            GlobalVar.GblCookie = new System.Net.CookieCollection();
            string[] dorkArray = txt_dorks.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string nbrPage = nbrPage_txt.Text;
            bool[] checkedMoteur = { chk_google.Checked, chk_bing.Checked, chk_yahoo.Checked, chk_yandex.Checked, chk_aol.Checked };
            Thread_Recherche = new Thread(() =>
            {
                Invoke((MethodInvoker)(() =>
                {
                    Demmare_Tache("Recherche URL", 0);
                }));
                Thread Thread_Google = new Thread(() => { return; });
                Thread Thread_Bing = new Thread(() => { return; });
                Thread Thread_Aol = new Thread(() => { return; });
                Thread Thread_Yahoo = new Thread(() => { return; });
                Thread Thread_Yandex = new Thread(() => { return; });
                if (checkedMoteur[0])
                {
                    Rechercheur rch = new Rechercheur();
                    Thread_Google = new Thread(() =>
                    {
                        rch.Google(dorkArray, nbrPage);
                        if (InvokeRequired) { Invoke((MethodInvoker)delegate { UpInfos(); }); return; }
                    });
                    Thread_Google.Start();
                }
                if (checkedMoteur[1])
                {
                    Rechercheur rch = new Rechercheur();
                    Thread_Bing = new Thread(() =>
                    {
                        rch.Bing(dorkArray, nbrPage);
                        if (InvokeRequired) { Invoke((MethodInvoker)delegate { UpInfos(); }); return; }
                    });
                    Thread_Bing.Start();
                }
                if (checkedMoteur[2])
                {
                    Rechercheur rch = new Rechercheur();
                    Thread_Yahoo = new Thread(() =>
                    {
                        rch.Yahoo(dorkArray, nbrPage);
                        if (InvokeRequired) { Invoke((MethodInvoker)delegate { UpInfos(); }); return; }
                    });
                    Thread_Yahoo.Start();
                }
                if (checkedMoteur[3])
                {
                    Rechercheur rch = new Rechercheur();
                    Thread_Yandex = new Thread(() =>
                    {
                        rch.Yandex(dorkArray, nbrPage);
                        if (InvokeRequired) { Invoke((MethodInvoker)delegate { UpInfos(); }); return; }
                    });
                    Thread_Yandex.Start();
                }
                if (checkedMoteur[4])
                {
                    Rechercheur rch = new Rechercheur();
                    Thread_Aol = new Thread(() =>
                    {
                        rch.Aol(dorkArray, nbrPage);
                        if (InvokeRequired) { Invoke((MethodInvoker)delegate { UpInfos(); }); return; }
                    });
                    Thread_Aol.Start();
                }
                if (Thread_Aol.IsAlive)
                {
                    Thread_Aol.Join();
                }
                if (Thread_Yahoo.IsAlive)
                {
                    Thread_Yahoo.Join();
                }
                if (Thread_Yandex.IsAlive)
                {
                    Thread_Yandex.Join();
                }
                if (Thread_Google.IsAlive)
                {
                    Thread_Google.Join();
                }
                if (Thread_Bing.IsAlive)
                {
                    Thread_Bing.Join();
                }

                Invoke((MethodInvoker)delegate
                {
                    TacheTerminer("Thread Recherche terminer", 0);
                });
            });
            Thread_Recherche.Start();
        }
        public List<string> CoupeDork(TextBox dorktextbox)
        {
            List<string> temporairelist = new List<string> { };
            foreach (string ligne in dorktextbox.Lines)
            {
                temporairelist.Add(ligne);
            }
            return temporairelist;
        }
        private bool suspend = false;
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (!suspend)
            {
                try 
                { 
                    Thread_Recherche.Suspend();
                    btn_stop.Text = "Reprendre";
                }
                catch { }
                suspend = true;
            }
            else
            {
                try
                {
                    Thread_Recherche.Resume();
                    btn_stop.Text = "Stop";
                }
                catch { }
                suspend = false;
            }
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            try { Thread_Recherche.Abort(); }
            catch { }
            TacheTerminer("Thread Recherche arrêtez", 0);
        }

        #endregion
        
        #region Clique Evenement
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void txt_monip_Click(object sender, EventArgs e)
        {
            setIP();
        }
        private void list_trv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void list_vulne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_exporte_url_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste des urls";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_url.Items)
                {
                    sw.WriteLine(lvi.SubItems[0].Text);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarder !", "Sauvegarde !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_importe_url_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Selectionné un fichier txt";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] text = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                list_url.BeginUpdate();
                foreach (string ligne in text)
                {
                    if (Uri.IsWellFormedUriString(ligne, UriKind.RelativeOrAbsolute))
                    {
                        list_url.Items.Add(ligne);
                    }
                    else
                    {
                        try
                        {
                            string[] objet = ligne.Split(new string[] { sp }, StringSplitOptions.None);
                            if (Uri.IsWellFormedUriString(objet[0], UriKind.RelativeOrAbsolute))
                                list_url.Items.Add(objet[0]);
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                }
                list_url.EndUpdate();
                UpInfos();
            }
        }
        private void btn_exporte_vulne_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste: vulnerable";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_vulne.Items)
                {
                    string groupe = "";
                    for (int i = 0; i < lvi.SubItems.Count; i++)
                    {
                        if (i == lvi.SubItems.Count - 1)
                            groupe += lvi.SubItems[i].Text;
                        else
                            groupe += lvi.SubItems[i].Text + "|";
                    }
                    sw.WriteLine(groupe);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarde!", "Sauvegarde reussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exporte_non_vulne(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste: non vulnerable";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_non_vulne.Items) 
                {
                    sw.WriteLine(lvi.SubItems[0].Text);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarde!", "Sauvegarde !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exporte_url_trash(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste: Trash";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_url_trash.Items) 
                {
                    sw.WriteLine(lvi.SubItems[0].Text);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarder !", "Sauvegarde !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exporte_ip_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste: Trash";
            
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_scanne_port.Items)
                {
                    string groupe = "";
                    for (int i = 0; i < lvi.SubItems.Count; i++)
                    {
                        if (i == lvi.SubItems.Count)
                            groupe += lvi.SubItems[i].Text;
                        else
                            groupe += lvi.SubItems[i].Text + "|";
                    }
                    sw.WriteLine(groupe);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarder !", "Sauvegarde !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exporte_analyseUrl_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texte fichier (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Sauvegarde la liste: Trash";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new System.IO.StreamWriter(savefile.FileName);
                foreach (ListViewItem lvi in list_injectables.Items)
                {
                    string groupe = "";
                    for (int i = 0; i < lvi.SubItems.Count; i++)
                    {
                        if (i == lvi.SubItems.Count)
                            groupe += lvi.SubItems[i].Text;
                        else
                            groupe += lvi.SubItems[i].Text + "|";
                    }
                    sw.WriteLine(groupe);
                }
                sw.Close();
                MessageBox.Show("Liste Sauvegarder !", "Sauvegarde !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_nettoyer_url_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir tout suprimmer ?", "Tout Suprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                list_url.BeginUpdate();
                list_url.Items.Clear();
                list_url.EndUpdate();
                UpInfos();
            }
        }
        private void btn_nettoyer_url_trash(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir tout suprimmer ?", "Tout Suprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                list_url_trash.BeginUpdate();
                list_url_trash.Items.Clear();
                list_url_trash.EndUpdate();
                UpInfos();
            }
        }
        private void btn_nettoyer_non_vulne(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir tout suprimmer ?", "Tout Suprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                list_non_vulne.BeginUpdate();
                list_non_vulne.Items.Clear();
                list_non_vulne.EndUpdate();
                UpInfos();
            }
        }
        private void effacer_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir tout suprimmer ?", "Tout Suprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                list_url.BeginUpdate();
                list_url.Items.Clear();
                list_url.EndUpdate();
                UpInfos();
            }
        }
        private void effacer_2_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir tout suprimmer ?", "Tout Suprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                list_vulne.BeginUpdate();
                list_vulne.Items.Clear();
                list_vulne.EndUpdate();
                UpInfos();
            }
        }

        #endregion

        #region Tout les Meunu Strip

        #region MeunuStrip Liste Vulne
        private void suprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_vulne.SelectedItems)
            {
                list_vulne.Items.Remove(lvi);
            }
        }
        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_vulne.SelectedItems)
            {
                Clipboard.SetText(lvi.SubItems[0].Text);
            }
        }
        private void ouvrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem urlselect in list_vulne.SelectedItems)
            {
                Process.Start(urlselect.Text);
            }
        }
        private void nettoyéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            list_vulne.Items.Clear();
        }
        #endregion
        #region MeunuStrip Liste Url
        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in list_url.SelectedItems)
            {
                list_url.Items.Remove(eachItem);
            }
        }
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem urlselect in list_url.SelectedItems)
            {
                Process.Start(urlselect.Text);
            }
        }
        private void copierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem urlselect in list_url.SelectedItems)
            {
                Clipboard.SetText(urlselect.SubItems[0].Text);
            }
        }
        private void nettoyéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_url.Items.Clear();
        }
        #endregion
        #region MeunuStrip UrlTrash
        private void ouvrirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem urlselect in list_url_trash.SelectedItems)
            {
                Process.Start(urlselect.Text);
            }
        }
        private void copierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_url_trash.SelectedItems)
            {
                Clipboard.SetText(lvi.Text);
            }
        }
        private void suprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_url_trash.SelectedItems)
            {
                list_url_trash.Items.Remove(lvi);
            }
        }
        private void nettoyéToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            list_url_trash.Items.Clear();
        }
        #endregion
        #region MeunuStrip Non Vulne
        private void ouvrirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem urlselect in list_non_vulne.SelectedItems)
            {
                Process.Start(urlselect.Text);
            }
        }
        private void copierToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_non_vulne.SelectedItems)
            {
                Clipboard.SetText(lvi.Text);
            }
        }
        private void suprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_non_vulne.SelectedItems)
            {
                list_non_vulne.Items.Remove(lvi);
            }
        }
        private void nettoyéToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            list_non_vulne.Items.Clear();
        }
        #endregion 
        #region MeunuStrip Liste PORT Ouvert
        private void copierPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_scanne_port.SelectedItems)
            {
                Clipboard.SetText(lvi.SubItems[1].Text);
            }
        }
        private void copierHoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_scanne_port.SelectedItems)
            {
                Clipboard.SetText(lvi.Text);
            }
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_scanne_port.SelectedItems)
            {
                list_scanne_port.Items.Remove(lvi);
            }
        }
        private void nettoyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_scanne_port.Items.Clear();
        } 
        #endregion
        #region MeunuStrip Injectables

        private void copierURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_injectables.SelectedItems)
            {
                Clipboard.SetText(lvi.Text);
            }
        }
        private void supprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_injectables.SelectedItems)
            {
                list_vulne.Items.Remove(lvi);
            }
        }
        private void dumperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_injectables.SelectedItems.Count > 0)
            {
                txt_url_dmp.Text = list_injectables.SelectedItems[0].Text;
                tabControl1.SelectedIndex = 2;
                btn_start_dmp_Click(sender, e);
            }
        }

        #endregion
        #region MeunuStrip UrlTrash
        private void ouvrirToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void copierToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void suprimmerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void suprimmerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #endregion

        #region Interface Echange Progress BAR

        private ProgressBar[] pb = new ProgressBar[6];
        private ProgressBar newProgressBar()
        {
            ProgressBar progressBar2 = new ProgressBar();
            progressBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            progressBar2.Location = new System.Drawing.Point(0, 0);
            progressBar2.MarqueeAnimationSpeed = 100;
            //progressBar2.Size = new System.Drawing.Size(1101, 27);
            progressBar2.Step = 100;
            progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            return progressBar2;
        }
        
        public void Demmare_Tache(string p, int tache)
        {
            fait_txt.Text = "[+] " + p;
            splitContainer2.Panel2Collapsed = false;
            switch (tache)
            {
                case 0:
                    pb[0] = new ProgressBar();
                    pb[0] = newProgressBar();
                    panel2.Controls.Add(pb[0]);
                    btn_importe_url.Enabled = false;
                    btn_recherche.Enabled = false;
                    btn_exporte.Enabled = false;
                    btn_stop.Cursor = Cursors.Default;
                    btn_exporte.Enabled = false;
                    btn_importe_url.Enabled = false;
                    break;
                case 1:
                    pb[1] = new ProgressBar();
                    pb[1] = newProgressBar();
                    panel2.Controls.Add(pb[1]);
                    btn_scanne_url_annuler.Enabled = true;
                    btn_scanneListeUrls.Enabled = false;
                    btn_exporte_vulne.Enabled = false;
                    btn_exporte_NonVulne.Enabled = false;
                    break;
                case 5:
                    pb[5] = new ProgressBar();
                    pb[5] = newProgressBar();
                    panel2.Controls.Add(pb[5]);
                    btn_analyseUrl.Enabled = false;
                    btn_exporte_analyseUrl.Enabled = false;
                    btn_annulerAnalyseUrl.Enabled = true;
                    break;
                case 2:
                    pb[2] = new ProgressBar();
                    pb[2] = newProgressBar();
                    panel2.Controls.Add(pb[2]);
                    btn_scannePort_annuler.Enabled = true;
                    btn_scanne_ip.Enabled = false;
                    btn_scannePort_annuler.Enabled = false;
                    btn_exporte_Portip.Enabled = true;
                    break;
                case 3:
                    pb[3] = new ProgressBar();
                    pb[3] = newProgressBar();
                    panel2.Controls.Add(pb[3]);
                    btn_annulerAnalyseUrl.Enabled = true;
                    btn_demmarer_analyse_url.Enabled = false;
                    btn_aller_dump.Enabled = false;
                    txt_url_analyse.Enabled = false;
                    btn_annuller_AnaUrl.Enabled = true;
                    break;
                case 4:
                    pb[4] = new ProgressBar();
                    pb[4] = newProgressBar();
                    panel2.Controls.Add(pb[4]);
                    btn_start_dmp.Enabled = false;
                    btn_annuler_dmp.Enabled = true;
                    txt_url_dmp.Enabled = false;
                    btn_get_dbs.Enabled = false;
                    btn_get_tables.Enabled = false;
                    btn_get_colonne.Enabled = false;
                    btn_get_donne.Enabled = false;
                    break;
                default:

                    break;
            }
        }
        public void TacheTerminer(string tache_nom, int task)
        {
            UpInfos();
            enrgistreDonne();
            switch (task)
            {
                case 0:
                  if (!pb[0].IsDisposed)
                        pb[0].Dispose();

                    btn_importe_url.Enabled = true;
                    btn_recherche.Enabled = true;
                    btn_exporte.Enabled = true;
                    btn_stop.Cursor = Cursors.Default;
                    btn_exporte.Enabled = true;
                    btn_importe_url.Enabled = true;
                    break;
                case 1:
                    if (!pb[1].IsDisposed)
                        pb[1].Dispose();
                    btn_scanne_url_annuler.Enabled = false;
                    btn_scanneListeUrls.Enabled = true;
                    btn_exporte_vulne.Enabled = true;
                    btn_exporte_NonVulne.Enabled = true;
                    break;
                case 2:
                    if (!pb[2].IsDisposed)
                        pb[2].Dispose();
                    btn_scannePort_annuler.Enabled = false;
                    btn_scanne_ip.Enabled = true;
                    btn_exporte_Portip.Enabled = true;
                    btn_scannePort_annuler.Enabled = false;
                    break;
                case 3:
                    if (!pb[3].IsDisposed)
                        pb[3].Dispose();
                    btn_demmarer_analyse_url.Enabled = true;
                    btn_aller_dump.Enabled = true;
                    txt_url_analyse.Enabled = true;
                    btn_annuller_AnaUrl.Enabled = false;
                    txt_statut_analyse.Text = "[+]";
                    break;
                case 5:
                    if (!pb[5].IsDisposed)
                        pb[5].Dispose();
                    btn_annulerAnalyseUrl.Enabled = false;
                    btn_analyseUrl.Enabled = true;
                    btn_exporte_analyseUrl.Enabled = true;
                    btn_annulerAnalyseUrl.Enabled = false;
                    break;
                case 4:
                    if (!pb[4].IsDisposed)
                        pb[4].Dispose();
                    btn_annuler_dmp.Enabled = false;
                    btn_start_dmp.Enabled = true;
                    txt_url_dmp.Enabled = true;

                    btn_get_dbs.Enabled = true;
                    btn_get_tables.Enabled = true;
                    btn_get_colonne.Enabled = true;
                    btn_get_donne.Enabled = true;
                    break;
                default:

                    break;
            }
            bool tacheRun = false;
            for (int i = 0; i < 5; i++)
            {
                if (pb[i] != null)
                {
                    if (pb[i].IsDisposed == false)
                    {
                        tacheRun = true;
                        break;
                    }
                }
            }
            if (tacheRun == false)
            {
                //Cache le Progress Bar et Arretez
                splitContainer2.Panel2Collapsed = true;
                splitContainer2.Panel2.Hide();
                fait_txt.Text = "[+] Terminer: " + tache_nom;
            }
            list_url.EndUpdate();
            list_vulne.EndUpdate();
            list_url_trash.EndUpdate();
            list_injectables.EndUpdate();
            list_non_vulne.EndUpdate();
            list_scanne_port.EndUpdate();
        }

        #endregion

        #region Scanne URLS trouver

        private void btn_scanne_url_annuler_Click(object sender, EventArgs e)
        {
            try { Thread_scanne.Abort(); }
            catch { }
            TacheTerminer("Thread Scanne arrêtez", 1);
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void demmare_scanne(List<string> urls)
        {
            ScanneFaille sf = new ScanneFaille();
            foreach (string url in urls)
            {
                Thread th = new Thread(() =>
                {
                    sf.Scanne(url);
                });
                th.Start();
                Thread.Sleep(115);
                UpInfos();
            }
        }

        #endregion

        #region Scanne PORT

        private string nomdomaine(string url)
        {
            try { return url.Split('/')[2];  }
            catch { return url; }
        }
        public Hashtable HashIP = new Hashtable();
        private void btn_scanne_ip_Click(object sender, EventArgs e)
        {
            Demmare_Tache("Scanne Port URLS demmaré", 2);

            List<string> urls = new List<string> { };
            if (chk_trvPort.Checked)
            {
                foreach (ListViewItem lvi in list_url.Items)
                {
                    urls.Add(lvi.SubItems[0].Text);
                }
            }
            if (chk_vulnePort.Checked)
            {
                foreach (ListViewItem lvi in list_vulne.Items)
                {
                    urls.Add(lvi.SubItems[0].Text);
                }
            }
            if (chk_urlInjectables.Checked)
            {
                foreach (ListViewItem lvi in list_injectables.Items)
                {
                    urls.Add(lvi.SubItems[0].Text);
                }
            }
            demmareScannePort(urls);
        }
        private void btn_scannePort_annuler_Click(object sender, EventArgs e)
        {
            try { Thread_scannePort.Abort(); }
            catch { }
            TacheTerminer("Thread Scanne Port arrêtez", 2);
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        public void demmareScannePort(List<string> urls)
        {
            ScannePort sp = new ScannePort();
            Thread_scannePort = new Thread(() =>
            {
                foreach (var url in urls)
                {
                    Thread th = new Thread(() =>
                    {
                        sp.Scanne(url);
                    });
                    th.Start();
                    Thread.Sleep(115);
                }
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        UpInfos();
                        TacheTerminer("Scanne Port", 2);
                    });
                    return;
                }
            });
            Thread_scannePort.Start();
        } 

        #endregion

        #region Analyse Injectable URLS

        private void btn_analyseUrl_Click(object sender, EventArgs e)
        {
            Demmare_Tache("Analyse URL demmarer", 5);

            List<string> URLS = new List<string> { };
            foreach (ListViewItem lvi in list_vulne.Items)
            {
                URLS.Add(lvi.SubItems[0].Text);
            }
            Thread_analyseUrls = new Thread(() =>
            {
                demmare_analyse(URLS);
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        UpInfos();
                        TacheTerminer("Analyse Faille", 5);
                    });
                    return;
                }
            });
            Thread_analyseUrls.Start();
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void demmare_analyse(List<string> urls)
        {
            ScanneAnalyse Sa = new ScanneAnalyse();
            int i = 0;
            foreach (string url in urls)
            {
                Thread th = new Thread(() =>
                {
                    Sa.Scanne(url);
                });
                th.Start();
                Thread.Sleep(1666);
                UpInfos();
                i++;
                if(i.ToString().Length > 1 && i.ToString().EndsWith("0"))
                {
                    Thread.Sleep(500 * i);
                }
            }
        }
        private void btn_annulerAnalyseUrl_Click(object sender, EventArgs e)
        {
            try { Thread_analyseUrls.Abort(); }
            catch { }
            TacheTerminer("Thread Scanne arrêtez", 5);
        }

        #endregion

        #region Analyse URL

        internal string url_point_scanne = "";
        private void btn_demmarer_analyse_url_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            txt_urlPointSucces.Visible = false;
            btn_aller_dump.Visible = false;
            string url = txt_url_analyse.Text;

            if (url.Contains("?") && url.Contains("="))
            {
                Demmare_Tache("Analyse URL Tache", 3);

                Thread_analyse = new Thread(() =>
                {
                    sql_inject inj = new sql_inject();
                    inj.Analyse(url);

                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            TacheTerminer("Analyse URL", 3);
                        });
                        return;
                    }
                });
                Thread_analyse.Start();
                btn_get_dbs.Enabled = true;
            }
            else
            {
                MessageBox.Show("URL format incorecte", "Erreur");
            }
        }
        private void btn_annuler_analyse_url_Click(object sender, EventArgs e)
        {
            try { Thread_analyse.Abort(); }catch { }
            TacheTerminer("Analyse URL", 3);
            txt_statut_analyse.Text = "[+]";
        }
        private void btn_aller_dump_Click(object sender, EventArgs e)
        {
            txt_url_dmp.Text = txt_urlPointSucces.Text;
            tabControl1.SelectedIndex = 3;
            btn_start_dmp_Click(sender, e);
        }
        #endregion

        #region Dumper

        private void btn_start_dmp_Click(object sender, EventArgs e)
        {
            txt_version.Text = string.Empty;
            txt_user.Text = string.Empty;
            txt_ipserveur.Text = string.Empty;
            tree_schema_dmp.Nodes.Clear();
            CheckedNode.Clear();
            dataGridView_dumper.Rows.Clear();
            dataGridView_dumper.Columns.Clear();

            string url = txt_url_dmp.Text;
            if (url.Contains("?") && url.Contains("=") && url.Contains("[t]"))
            {
                Demmare_Tache("Dumper Tache demmaré", 4);
                dataGridView_dumper.Rows.Clear();
                dataGridView_dumper.Columns.Clear();
                Thread_Dumper = new Thread(() =>
                {
                    dmp = new Sqli_dumper();
                    if (dmp.controlleur(url))
                    {
                        splitContainer12.Invoke((MethodInvoker)(() =>
                        {
                            btn_get_dbs.Enabled = true;
                        }));
                    }
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            TacheTerminer("Dumper Tache", 4);
                        });
                        return;
                    }
                });
                Thread_Dumper.Start();
            }
            else
            {
                MessageBox.Show("URL format incorecte", "ERREUR");
            }
        }
        private void btn_annuler_dmp_Click(object sender, EventArgs e)
        {
            try
            {
                Thread_Dumper.Abort();
            }
            catch { }
            TacheTerminer("Dumper Tache", 4);
        }
        private Sqli_dumper dmp;
        public static List<String> CheckedNode = new List<String>();
        private void btn_get_dbs_Click(object sender, EventArgs e)
        {
            Demmare_Tache("Dumper Tache demmaré", 4);
            tree_schema_dmp.Nodes.Clear();
            Thread_Dumper = new Thread(() =>
            {
                dmp.setAllBD();
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        TacheTerminer("Dumper Tache", 4);
                    });
                    return;
                }
                Thread_Dumper.Start();
            });
        }
        private void btn_get_tables_Click(object sender, EventArgs e)
        {
            if (CheckedNode.Count > 0)
            {
                Demmare_Tache("Dumper Tache demmaré", 4);
                Thread_Dumper = new Thread(() =>
                {
                    dmp.setTable(CheckedNode.ToArray());
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            TacheTerminer("Dumper Tache", 4);
                        });
                        return;
                    }
                });
                Thread_Dumper.Start();
            }
        }
        private void btn_get_colonne_Click(object sender, EventArgs e)
        {
            int index_tb = tree_schema_dmp.SelectedNode.Index;
            if (CheckedNode.Count > 0)
            {
                Demmare_Tache("Dumper Tache demmaré", 4);
                Thread_Dumper = new Thread(() =>
                {
                    dmp.setColonne(CheckedNode.ToArray());
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            TacheTerminer("Dumper Tache", 4);
                        });
                    }
                });
                Thread_Dumper.Start();
            }
        }
        private void btn_get_donne_Click(object sender, EventArgs e)
        {
            tree_schema_dmp.SelectedNode.Nodes.Clear();

            if (CheckedNode.ToArray().Length > 0)
            {
                Demmare_Tache("Dumper Tache demmaré", 4);
                Thread_Dumper = new Thread(() =>
                {
                    dmp.setDonne(CheckedNode.ToArray());
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            TacheTerminer("Dumper Tache", 4);
                        });
                    }
                    UncheckTreeView(tree_schema_dmp);
                });
                Thread_Dumper.Start();
                tree_schema_dmp.ExpandAll();
            }
        }
        private void tree_schema_dmp_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        private void tree_schema_dmp_AfterCheck(object sender, TreeViewEventArgs e)
        {
            string[] mrc = e.Node.FullPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            if (mrc.Length == 1)
            {
                if (e.Node.Checked)
                {
                    CheckedNode.Add(e.Node.FullPath);
                    CheckTreeView(e.Node.Nodes);
                }
                else
                {
                    CheckedNode.Remove(e.Node.FullPath);
                    UncheckTreeView(e.Node.Nodes);
                }
            }
            else if (mrc.Length == 2)
            {
                if (e.Node.Checked)
                {
                    CheckedNode.Add(e.Node.FullPath + @"\");
                }
                else
                {
                    CheckedNode.Remove(e.Node.FullPath + @"\");
                }
            }
            else if (mrc.Length == 3)
            {
                int indexC = -1;
                indexC = CheckedNode.FindIndex(item => item.StartsWith(mrc[0] + @"\" + mrc[1])); 
                
                if (indexC != -1)
                {
                    if (e.Node.Checked)
                    {
                        CheckedNode[indexC] += ("[-COL]" + Path.GetFileName(e.Node.FullPath));
                    }
                    else
                    {
                        CheckedNode[indexC] = (e.Node.FullPath + CheckedNode[indexC].Replace("[-COL]" + Path.GetFileName(e.Node.FullPath), ""));
                    }
                }
                else
                {
                    if (e.Node.Checked)
                    {
                        CheckedNode.Add(e.Node.FullPath + "[-COL]" + Path.GetFileName(e.Node.FullPath));
                    }
                    else
                    {
                        CheckedNode.Add(e.Node.FullPath + "[-COL]");
                    }
                }
            }
        }
        private string GetColonneTableNode(TreeNode node)
        {
            string concat = string.Empty;
            foreach (TreeNode Snode in node.Nodes)
            {
                concat += Path.GetFileName(Snode.FullPath) + "[-COL]";
            }
            return concat;
        }
        public void UncheckTreeView(TreeView tv)
        {
            tv.Invoke((MethodInvoker)(() =>
            {
                tv.BeginUpdate();
                foreach (TreeNode tn in tv.Nodes)
                {
                    tn.Checked = false;
                    UncheckTreeView(tn);
                }
                tv.EndUpdate();
            }));
        }
        private void CheckTreeView(TreeNodeCollection treeNodeCollection)
        {
            if (treeNodeCollection.IsReadOnly)
            {   
                foreach (TreeNode tn in treeNodeCollection)
                {
                    tn.TreeView.Invoke((MethodInvoker)(() =>
                    {
                        tn.Checked = true;
                    }));
                }
                foreach (TreeNode tn in treeNodeCollection)
                {
                    tn.TreeView.Invoke((MethodInvoker)(() =>
                    {
                        tn.Parent.Checked = true;
                    }));
                }
            }
        }
        private void UncheckTreeView(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode tn in treeNodeCollection)
            {
                tn.TreeView.Invoke((MethodInvoker)(() =>
                {
                    tn.Checked = false;
                }));
            }
        }
        public void UncheckTreeView(TreeNode node)
        {
            try
            {
                foreach (TreeNode tn in node.Nodes)
                {
                    tn.Checked = false;
                    UncheckTreeView(tn);
                }
            }
            catch {}
        }
        private void tree_schema_dmp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tree_schema_dmp.SelectedNode.Checked)
                    tree_schema_dmp.SelectedNode.Checked = false;
                else
                    tree_schema_dmp.SelectedNode.Checked = true;
            }
            catch
            {
                
            }
        }
        #endregion







    }

    
}
