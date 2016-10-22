using SQl_SCanner;
namespace SQl_SCanner
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_monip = new System.Windows.Forms.ToolStripStatusLabel();
            this.fait_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripUrl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripVulne = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.suprimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyéToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripPort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierHoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.MeunuInjectables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimmerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNonVulne = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyéToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUrlTrash = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyéToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgTab = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_nbr_scannePort = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_nettoyer_url = new System.Windows.Forms.Button();
            this.btn_exporte = new System.Windows.Forms.Button();
            this.btn_importe_url = new System.Windows.Forms.Button();
            this.txt_dorks = new System.Windows.Forms.TextBox();
            this.chk_aol = new System.Windows.Forms.CheckBox();
            this.chk_yahoo = new System.Windows.Forms.CheckBox();
            this.chk_yandex = new System.Windows.Forms.CheckBox();
            this.chk_bing = new System.Windows.Forms.CheckBox();
            this.chk_google = new System.Windows.Forms.CheckBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.nbrPage_txt = new System.Windows.Forms.NumericUpDown();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.txt_recherche_infos = new System.Windows.Forms.TextBox();
            this.list_url = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_scanne_url_annuler = new System.Windows.Forms.Button();
            this.btn_scanneListeUrls = new System.Windows.Forms.Button();
            this.btn_exporte_vulne = new System.Windows.Forms.Button();
            this.list_vulne = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer13 = new System.Windows.Forms.SplitContainer();
            this.btn_annulerAnalyseUrl = new System.Windows.Forms.Button();
            this.btn_analyseUrl = new System.Windows.Forms.Button();
            this.btn_exporte_analyseUrl = new System.Windows.Forms.Button();
            this.list_injectables = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btn_exporte_NonVulne = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.list_non_vulne = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.chk_urlInjectables = new System.Windows.Forms.CheckBox();
            this.chk_vulnePort = new System.Windows.Forms.CheckBox();
            this.chk_trvPort = new System.Windows.Forms.CheckBox();
            this.btn_infos_scannePort = new System.Windows.Forms.Button();
            this.btn_scannePort_annuler = new System.Windows.Forms.Button();
            this.btn_exporte_Portip = new System.Windows.Forms.Button();
            this.btn_scanne_ip = new System.Windows.Forms.Button();
            this.list_scanne_port = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.list_url_trash = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nbr_nonVulne = new System.Windows.Forms.Label();
            this.txt_nbr_injectable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nbr_trouver = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nbr_vulne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.txt_statut_analyse = new System.Windows.Forms.Label();
            this.btn_annuller_AnaUrl = new System.Windows.Forms.Button();
            this.btn_stop_analyse_url = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_demmarer_analyse_url = new System.Windows.Forms.Button();
            this.txt_url_analyse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupInfoAnaluse = new System.Windows.Forms.GroupBox();
            this.txt_LoadFileAnalyse = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_urlPointSucces = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aller_dump = new System.Windows.Forms.Button();
            this.txt_versionAnalyse = new System.Windows.Forms.Label();
            this.txt_userAnalyse = new System.Windows.Forms.Label();
            this.txt_ipAnalyse = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_version = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.txt_ipserveur = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_url_dmp = new System.Windows.Forms.TextBox();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.btn_get_donne = new System.Windows.Forms.Button();
            this.btn_get_colonne = new System.Windows.Forms.Button();
            this.btn_get_tables = new System.Windows.Forms.Button();
            this.btn_get_dbs = new System.Windows.Forms.Button();
            this.tree_schema_dmp = new System.Windows.Forms.TreeView();
            this.btn_start_dmp = new System.Windows.Forms.Button();
            this.btn_annuler_dmp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_dumper = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripUrl.SuspendLayout();
            this.MenuStripVulne.SuspendLayout();
            this.MenuStripPort.SuspendLayout();
            this.MeunuInjectables.SuspendLayout();
            this.MenuNonVulne.SuspendLayout();
            this.MenuUrlTrash.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrPage_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).BeginInit();
            this.splitContainer13.Panel1.SuspendLayout();
            this.splitContainer13.Panel2.SuspendLayout();
            this.splitContainer13.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupInfoAnaluse.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dumper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_monip,
            this.fait_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_monip
            // 
            this.txt_monip.LinkVisited = true;
            this.txt_monip.Name = "txt_monip";
            this.txt_monip.Size = new System.Drawing.Size(45, 17);
            this.txt_monip.Text = "IP: N/A";
            this.txt_monip.Click += new System.EventHandler(this.txt_monip_Click);
            // 
            // fait_txt
            // 
            this.fait_txt.Name = "fait_txt";
            this.fait_txt.Size = new System.Drawing.Size(23, 17);
            this.fait_txt.Text = "[+]";
            // 
            // contextMenuStripUrl
            // 
            this.contextMenuStripUrl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripUrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.suprimerToolStripMenuItem,
            this.copierToolStripMenuItem1,
            this.nettoyéToolStripMenuItem});
            this.contextMenuStripUrl.Name = "contextMenuStrip1";
            this.contextMenuStripUrl.Size = new System.Drawing.Size(161, 92);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.suprimerToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem1
            // 
            this.copierToolStripMenuItem1.Name = "copierToolStripMenuItem1";
            this.copierToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.copierToolStripMenuItem1.Text = "Copier";
            this.copierToolStripMenuItem1.Click += new System.EventHandler(this.copierToolStripMenuItem1_Click);
            // 
            // nettoyéToolStripMenuItem
            // 
            this.nettoyéToolStripMenuItem.Name = "nettoyéToolStripMenuItem";
            this.nettoyéToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nettoyéToolStripMenuItem.Text = "Suprimmer Tout";
            this.nettoyéToolStripMenuItem.Click += new System.EventHandler(this.nettoyéToolStripMenuItem_Click);
            // 
            // MenuStripVulne
            // 
            this.MenuStripVulne.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripVulne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suprimmerToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.ouvrirToolStripMenuItem1,
            this.nettoyéToolStripMenuItem1});
            this.MenuStripVulne.Name = "contextMenuStripVulne";
            this.MenuStripVulne.Size = new System.Drawing.Size(161, 92);
            // 
            // suprimmerToolStripMenuItem
            // 
            this.suprimmerToolStripMenuItem.Name = "suprimmerToolStripMenuItem";
            this.suprimmerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.suprimmerToolStripMenuItem.Text = "Suprimmer";
            this.suprimmerToolStripMenuItem.Click += new System.EventHandler(this.suprimmerToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem1
            // 
            this.ouvrirToolStripMenuItem1.Name = "ouvrirToolStripMenuItem1";
            this.ouvrirToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.ouvrirToolStripMenuItem1.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem1.Click += new System.EventHandler(this.ouvrirToolStripMenuItem1_Click);
            // 
            // nettoyéToolStripMenuItem1
            // 
            this.nettoyéToolStripMenuItem1.Name = "nettoyéToolStripMenuItem1";
            this.nettoyéToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.nettoyéToolStripMenuItem1.Text = "Suprimmer Tout";
            this.nettoyéToolStripMenuItem1.Click += new System.EventHandler(this.nettoyéToolStripMenuItem1_Click);
            // 
            // MenuStripPort
            // 
            this.MenuStripPort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripPort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierPortToolStripMenuItem,
            this.copierHoteToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.nettoyerToolStripMenuItem});
            this.MenuStripPort.Name = "contextMenuStripPort";
            this.MenuStripPort.Size = new System.Drawing.Size(161, 92);
            // 
            // copierPortToolStripMenuItem
            // 
            this.copierPortToolStripMenuItem.Name = "copierPortToolStripMenuItem";
            this.copierPortToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copierPortToolStripMenuItem.Text = "Copier IP";
            this.copierPortToolStripMenuItem.Click += new System.EventHandler(this.copierPortToolStripMenuItem_Click);
            // 
            // copierHoteToolStripMenuItem
            // 
            this.copierHoteToolStripMenuItem.Name = "copierHoteToolStripMenuItem";
            this.copierHoteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copierHoteToolStripMenuItem.Text = "Copier Hote";
            this.copierHoteToolStripMenuItem.Click += new System.EventHandler(this.copierHoteToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.supprimerToolStripMenuItem.Text = "Suprimmer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // nettoyerToolStripMenuItem
            // 
            this.nettoyerToolStripMenuItem.Name = "nettoyerToolStripMenuItem";
            this.nettoyerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nettoyerToolStripMenuItem.Text = "Suprimmer Tout";
            this.nettoyerToolStripMenuItem.Click += new System.EventHandler(this.nettoyerToolStripMenuItem_Click);
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 23);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1085, 543);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // MeunuInjectables
            // 
            this.MeunuInjectables.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MeunuInjectables.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MeunuInjectables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierURLToolStripMenuItem,
            this.dumperToolStripMenuItem,
            this.supprimmerToolStripMenuItem,
            this.suprimmerToutToolStripMenuItem});
            this.MeunuInjectables.Name = "MeunuInjectables";
            this.MeunuInjectables.Size = new System.Drawing.Size(161, 92);
            // 
            // copierURLToolStripMenuItem
            // 
            this.copierURLToolStripMenuItem.Name = "copierURLToolStripMenuItem";
            this.copierURLToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copierURLToolStripMenuItem.Text = "Copier URL";
            this.copierURLToolStripMenuItem.Click += new System.EventHandler(this.copierURLToolStripMenuItem_Click);
            // 
            // dumperToolStripMenuItem
            // 
            this.dumperToolStripMenuItem.Name = "dumperToolStripMenuItem";
            this.dumperToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dumperToolStripMenuItem.Text = "Dumper";
            this.dumperToolStripMenuItem.Click += new System.EventHandler(this.dumperToolStripMenuItem_Click);
            // 
            // supprimmerToolStripMenuItem
            // 
            this.supprimmerToolStripMenuItem.Name = "supprimmerToolStripMenuItem";
            this.supprimmerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.supprimmerToolStripMenuItem.Text = "Suprimmer";
            this.supprimmerToolStripMenuItem.Click += new System.EventHandler(this.supprimmerToolStripMenuItem_Click);
            // 
            // suprimmerToutToolStripMenuItem
            // 
            this.suprimmerToutToolStripMenuItem.Name = "suprimmerToutToolStripMenuItem";
            this.suprimmerToutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.suprimmerToutToolStripMenuItem.Text = "Suprimmer Tout";
            // 
            // MenuNonVulne
            // 
            this.MenuNonVulne.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MenuNonVulne.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuNonVulne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem3,
            this.copierToolStripMenuItem3,
            this.suprimerToolStripMenuItem1,
            this.nettoyéToolStripMenuItem3});
            this.MenuNonVulne.Name = "contextMenuStripNonVulne";
            this.MenuNonVulne.Size = new System.Drawing.Size(161, 92);
            // 
            // ouvrirToolStripMenuItem3
            // 
            this.ouvrirToolStripMenuItem3.Name = "ouvrirToolStripMenuItem3";
            this.ouvrirToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.ouvrirToolStripMenuItem3.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem3.Click += new System.EventHandler(this.ouvrirToolStripMenuItem3_Click);
            // 
            // copierToolStripMenuItem3
            // 
            this.copierToolStripMenuItem3.Name = "copierToolStripMenuItem3";
            this.copierToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.copierToolStripMenuItem3.Text = "Copier";
            this.copierToolStripMenuItem3.Click += new System.EventHandler(this.copierToolStripMenuItem3_Click);
            // 
            // suprimerToolStripMenuItem1
            // 
            this.suprimerToolStripMenuItem1.Name = "suprimerToolStripMenuItem1";
            this.suprimerToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.suprimerToolStripMenuItem1.Text = "Suprimer";
            this.suprimerToolStripMenuItem1.Click += new System.EventHandler(this.suprimerToolStripMenuItem1_Click);
            // 
            // nettoyéToolStripMenuItem3
            // 
            this.nettoyéToolStripMenuItem3.Name = "nettoyéToolStripMenuItem3";
            this.nettoyéToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.nettoyéToolStripMenuItem3.Text = "Suprimmer Tout";
            this.nettoyéToolStripMenuItem3.Click += new System.EventHandler(this.nettoyéToolStripMenuItem3_Click);
            // 
            // MenuUrlTrash
            // 
            this.MenuUrlTrash.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MenuUrlTrash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuUrlTrash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem2,
            this.copierToolStripMenuItem2,
            this.suprimerToolStripMenuItem2,
            this.nettoyéToolStripMenuItem2});
            this.MenuUrlTrash.Name = "contextMenuStripTrash";
            this.MenuUrlTrash.Size = new System.Drawing.Size(161, 92);
            // 
            // ouvrirToolStripMenuItem2
            // 
            this.ouvrirToolStripMenuItem2.Name = "ouvrirToolStripMenuItem2";
            this.ouvrirToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.ouvrirToolStripMenuItem2.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem2.Click += new System.EventHandler(this.ouvrirToolStripMenuItem2_Click);
            // 
            // copierToolStripMenuItem2
            // 
            this.copierToolStripMenuItem2.Name = "copierToolStripMenuItem2";
            this.copierToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.copierToolStripMenuItem2.Text = "Copier";
            this.copierToolStripMenuItem2.Click += new System.EventHandler(this.copierToolStripMenuItem2_Click);
            // 
            // suprimerToolStripMenuItem2
            // 
            this.suprimerToolStripMenuItem2.Name = "suprimerToolStripMenuItem2";
            this.suprimerToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.suprimerToolStripMenuItem2.Text = "Suprimmer";
            this.suprimerToolStripMenuItem2.Click += new System.EventHandler(this.suprimerToolStripMenuItem2_Click);
            // 
            // nettoyéToolStripMenuItem2
            // 
            this.nettoyéToolStripMenuItem2.Name = "nettoyéToolStripMenuItem2";
            this.nettoyéToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.nettoyéToolStripMenuItem2.Text = "Suprimmer Tout";
            this.nettoyéToolStripMenuItem2.Click += new System.EventHandler(this.nettoyéToolStripMenuItem2_Click);
            // 
            // ImgTab
            // 
            this.ImgTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgTab.ImageStream")));
            this.ImgTab.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgTab.Images.SetKeyName(0, "trashed.png");
            this.ImgTab.Images.SetKeyName(1, "trash.png");
            this.ImgTab.Images.SetKeyName(2, "succes.png");
            this.ImgTab.Images.SetKeyName(3, "search.png");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 22);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(166, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 519);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_nbr_scannePort);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_nbr_nonVulne);
            this.tabPage1.Controls.Add(this.txt_nbr_injectable);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txt_nbr_trouver);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_nbr_vulne);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Masse Scanneur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_nbr_scannePort
            // 
            this.txt_nbr_scannePort.AutoSize = true;
            this.txt_nbr_scannePort.BackColor = System.Drawing.Color.Snow;
            this.txt_nbr_scannePort.Location = new System.Drawing.Point(757, 8);
            this.txt_nbr_scannePort.Name = "txt_nbr_scannePort";
            this.txt_nbr_scannePort.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.txt_nbr_scannePort.Size = new System.Drawing.Size(35, 14);
            this.txt_nbr_scannePort.TabIndex = 12;
            this.txt_nbr_scannePort.Text = "0     ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tabControl2);
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 468);
            this.panel3.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.ImageList = this.ImgTab;
            this.tabControl2.ItemSize = new System.Drawing.Size(166, 25);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(9, 3);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1024, 468);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 35;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Controls.Add(this.toolStripContainer1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 435);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Recherche URL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_nettoyer_url);
            this.splitContainer1.Panel1.Controls.Add(this.btn_exporte);
            this.splitContainer1.Panel1.Controls.Add(this.btn_importe_url);
            this.splitContainer1.Panel1.Controls.Add(this.txt_dorks);
            this.splitContainer1.Panel1.Controls.Add(this.chk_aol);
            this.splitContainer1.Panel1.Controls.Add(this.chk_yahoo);
            this.splitContainer1.Panel1.Controls.Add(this.chk_yandex);
            this.splitContainer1.Panel1.Controls.Add(this.chk_bing);
            this.splitContainer1.Panel1.Controls.Add(this.chk_google);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel1.Controls.Add(this.nbrPage_txt);
            this.splitContainer1.Panel1.Controls.Add(this.btn_recherche);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 429);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 39;
            // 
            // btn_nettoyer_url
            // 
            this.btn_nettoyer_url.Location = new System.Drawing.Point(153, 158);
            this.btn_nettoyer_url.Name = "btn_nettoyer_url";
            this.btn_nettoyer_url.Size = new System.Drawing.Size(73, 25);
            this.btn_nettoyer_url.TabIndex = 63;
            this.btn_nettoyer_url.Text = "Nettoyer";
            this.btn_nettoyer_url.UseVisualStyleBackColor = true;
            this.btn_nettoyer_url.Click += new System.EventHandler(this.btn_nettoyer_url_Click);
            // 
            // btn_exporte
            // 
            this.btn_exporte.Location = new System.Drawing.Point(77, 158);
            this.btn_exporte.Name = "btn_exporte";
            this.btn_exporte.Size = new System.Drawing.Size(70, 25);
            this.btn_exporte.TabIndex = 61;
            this.btn_exporte.Text = "Exporter";
            this.btn_exporte.UseVisualStyleBackColor = true;
            this.btn_exporte.Click += new System.EventHandler(this.btn_exporte_url_Click);
            // 
            // btn_importe_url
            // 
            this.btn_importe_url.Location = new System.Drawing.Point(6, 158);
            this.btn_importe_url.Name = "btn_importe_url";
            this.btn_importe_url.Size = new System.Drawing.Size(65, 25);
            this.btn_importe_url.TabIndex = 62;
            this.btn_importe_url.Text = "Importer";
            this.btn_importe_url.UseVisualStyleBackColor = true;
            this.btn_importe_url.Click += new System.EventHandler(this.btn_importe_url_Click);
            // 
            // txt_dorks
            // 
            this.txt_dorks.AcceptsReturn = true;
            this.txt_dorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dorks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dorks.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQl_SCanner.Properties.Settings.Default, "dork", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_dorks.Location = new System.Drawing.Point(251, 3);
            this.txt_dorks.Multiline = true;
            this.txt_dorks.Name = "txt_dorks";
            this.txt_dorks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_dorks.Size = new System.Drawing.Size(586, 180);
            this.txt_dorks.TabIndex = 72;
            this.txt_dorks.Text = global::SQl_SCanner.Properties.Settings.Default.dork;
            // 
            // chk_aol
            // 
            this.chk_aol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_aol.AutoSize = true;
            this.chk_aol.Checked = global::SQl_SCanner.Properties.Settings.Default.aol;
            this.chk_aol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_aol.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SQl_SCanner.Properties.Settings.Default, "aol", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_aol.Location = new System.Drawing.Point(864, 94);
            this.chk_aol.Name = "chk_aol";
            this.chk_aol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_aol.Size = new System.Drawing.Size(49, 18);
            this.chk_aol.TabIndex = 71;
            this.chk_aol.Text = "AOL";
            this.chk_aol.UseVisualStyleBackColor = true;
            // 
            // chk_yahoo
            // 
            this.chk_yahoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_yahoo.AutoSize = true;
            this.chk_yahoo.Checked = global::SQl_SCanner.Properties.Settings.Default.yahoo;
            this.chk_yahoo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_yahoo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SQl_SCanner.Properties.Settings.Default, "yahoo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_yahoo.Location = new System.Drawing.Point(864, 70);
            this.chk_yahoo.Name = "chk_yahoo";
            this.chk_yahoo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_yahoo.Size = new System.Drawing.Size(61, 18);
            this.chk_yahoo.TabIndex = 69;
            this.chk_yahoo.Text = "Yahoo";
            this.chk_yahoo.UseVisualStyleBackColor = true;
            // 
            // chk_yandex
            // 
            this.chk_yandex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_yandex.AutoSize = true;
            this.chk_yandex.Checked = global::SQl_SCanner.Properties.Settings.Default.yandex;
            this.chk_yandex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_yandex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SQl_SCanner.Properties.Settings.Default, "yandex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_yandex.Location = new System.Drawing.Point(864, 118);
            this.chk_yandex.Name = "chk_yandex";
            this.chk_yandex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_yandex.Size = new System.Drawing.Size(67, 18);
            this.chk_yandex.TabIndex = 70;
            this.chk_yandex.Text = "Yandex";
            this.chk_yandex.UseVisualStyleBackColor = true;
            // 
            // chk_bing
            // 
            this.chk_bing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_bing.AutoSize = true;
            this.chk_bing.Checked = global::SQl_SCanner.Properties.Settings.Default.bing;
            this.chk_bing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_bing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SQl_SCanner.Properties.Settings.Default, "bing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_bing.Location = new System.Drawing.Point(864, 46);
            this.chk_bing.Name = "chk_bing";
            this.chk_bing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_bing.Size = new System.Drawing.Size(49, 18);
            this.chk_bing.TabIndex = 68;
            this.chk_bing.Text = "Bing";
            this.chk_bing.UseVisualStyleBackColor = true;
            // 
            // chk_google
            // 
            this.chk_google.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_google.AutoSize = true;
            this.chk_google.Checked = global::SQl_SCanner.Properties.Settings.Default.google;
            this.chk_google.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_google.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SQl_SCanner.Properties.Settings.Default, "google", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chk_google.Location = new System.Drawing.Point(864, 22);
            this.chk_google.Name = "chk_google";
            this.chk_google.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_google.Size = new System.Drawing.Size(64, 18);
            this.chk_google.TabIndex = 67;
            this.chk_google.Text = "Google";
            this.chk_google.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.FlatAppearance.BorderSize = 2;
            this.btn_stop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_stop.Location = new System.Drawing.Point(6, 41);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(220, 25);
            this.btn_stop.TabIndex = 64;
            this.btn_stop.Text = "Pause";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // nbrPage_txt
            // 
            this.nbrPage_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SQl_SCanner.Properties.Settings.Default, "Index", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nbrPage_txt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbrPage_txt.Location = new System.Drawing.Point(51, 82);
            this.nbrPage_txt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nbrPage_txt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrPage_txt.Name = "nbrPage_txt";
            this.nbrPage_txt.Size = new System.Drawing.Size(98, 22);
            this.nbrPage_txt.TabIndex = 66;
            this.nbrPage_txt.Value = global::SQl_SCanner.Properties.Settings.Default.Index;
            // 
            // btn_recherche
            // 
            this.btn_recherche.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_recherche.FlatAppearance.BorderSize = 2;
            this.btn_recherche.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_recherche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_recherche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_recherche.Location = new System.Drawing.Point(6, 10);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(220, 25);
            this.btn_recherche.TabIndex = 60;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.recherche_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "Index:";
            // 
            // splitContainer8
            // 
            this.splitContainer8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.txt_recherche_infos);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.list_url);
            this.splitContainer8.Size = new System.Drawing.Size(1010, 238);
            this.splitContainer8.SplitterDistance = 217;
            this.splitContainer8.TabIndex = 35;
            // 
            // txt_recherche_infos
            // 
            this.txt_recherche_infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_recherche_infos.Location = new System.Drawing.Point(0, 0);
            this.txt_recherche_infos.Multiline = true;
            this.txt_recherche_infos.Name = "txt_recherche_infos";
            this.txt_recherche_infos.Size = new System.Drawing.Size(217, 238);
            this.txt_recherche_infos.TabIndex = 0;
            // 
            // list_url
            // 
            this.list_url.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.list_url.ContextMenuStrip = this.contextMenuStripUrl;
            this.list_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_url.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_url.FullRowSelect = true;
            this.list_url.Location = new System.Drawing.Point(0, 0);
            this.list_url.Name = "list_url";
            this.list_url.Size = new System.Drawing.Size(789, 238);
            this.list_url.TabIndex = 34;
            this.list_url.UseCompatibleStateImageBehavior = false;
            this.list_url.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "La liste des url";
            this.columnHeader1.Text = "URL";
            this.columnHeader1.Width = 840;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(891, 48);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 581);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(891, 73);
            this.toolStripContainer1.TabIndex = 28;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pages:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1016, 435);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Vulnerables URL";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_scanne_url_annuler);
            this.splitContainer3.Panel1.Controls.Add(this.btn_scanneListeUrls);
            this.splitContainer3.Panel1.Controls.Add(this.btn_exporte_vulne);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.list_vulne);
            this.splitContainer3.Size = new System.Drawing.Size(1010, 429);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_scanne_url_annuler
            // 
            this.btn_scanne_url_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scanne_url_annuler.Enabled = false;
            this.btn_scanne_url_annuler.Location = new System.Drawing.Point(710, -1);
            this.btn_scanne_url_annuler.Name = "btn_scanne_url_annuler";
            this.btn_scanne_url_annuler.Size = new System.Drawing.Size(147, 24);
            this.btn_scanne_url_annuler.TabIndex = 2;
            this.btn_scanne_url_annuler.Text = "Annuler";
            this.btn_scanne_url_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_scanneListeUrls
            // 
            this.btn_scanneListeUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scanneListeUrls.Location = new System.Drawing.Point(863, 0);
            this.btn_scanneListeUrls.Name = "btn_scanneListeUrls";
            this.btn_scanneListeUrls.Size = new System.Drawing.Size(147, 24);
            this.btn_scanneListeUrls.TabIndex = 1;
            this.btn_scanneListeUrls.Text = "Scanne URLS";
            this.btn_scanneListeUrls.UseVisualStyleBackColor = true;
            // 
            // btn_exporte_vulne
            // 
            this.btn_exporte_vulne.Location = new System.Drawing.Point(0, 0);
            this.btn_exporte_vulne.Name = "btn_exporte_vulne";
            this.btn_exporte_vulne.Size = new System.Drawing.Size(132, 24);
            this.btn_exporte_vulne.TabIndex = 0;
            this.btn_exporte_vulne.Text = "Exporte";
            this.btn_exporte_vulne.UseVisualStyleBackColor = true;
            this.btn_exporte_vulne.Click += new System.EventHandler(this.btn_exporte_vulne_Click);
            // 
            // list_vulne
            // 
            this.list_vulne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_vulne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader3});
            this.list_vulne.ContextMenuStrip = this.MenuStripVulne;
            this.list_vulne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_vulne.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_vulne.FullRowSelect = true;
            this.list_vulne.GridLines = true;
            this.list_vulne.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_vulne.HideSelection = false;
            this.list_vulne.Location = new System.Drawing.Point(0, 0);
            this.list_vulne.Name = "list_vulne";
            this.list_vulne.Size = new System.Drawing.Size(1010, 399);
            this.list_vulne.TabIndex = 1;
            this.list_vulne.UseCompatibleStateImageBehavior = false;
            this.list_vulne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 703;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SQL";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Verifie le";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            this.columnHeader3.Width = 159;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer13);
            this.tabPage5.ImageIndex = 2;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1016, 435);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Injectables URL";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer13
            // 
            this.splitContainer13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer13.Location = new System.Drawing.Point(3, 3);
            this.splitContainer13.Name = "splitContainer13";
            this.splitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            this.splitContainer13.Panel1.Controls.Add(this.btn_annulerAnalyseUrl);
            this.splitContainer13.Panel1.Controls.Add(this.btn_analyseUrl);
            this.splitContainer13.Panel1.Controls.Add(this.btn_exporte_analyseUrl);
            // 
            // splitContainer13.Panel2
            // 
            this.splitContainer13.Panel2.Controls.Add(this.list_injectables);
            this.splitContainer13.Size = new System.Drawing.Size(1010, 429);
            this.splitContainer13.SplitterDistance = 25;
            this.splitContainer13.TabIndex = 0;
            // 
            // btn_annulerAnalyseUrl
            // 
            this.btn_annulerAnalyseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annulerAnalyseUrl.Enabled = false;
            this.btn_annulerAnalyseUrl.Location = new System.Drawing.Point(705, 0);
            this.btn_annulerAnalyseUrl.Name = "btn_annulerAnalyseUrl";
            this.btn_annulerAnalyseUrl.Size = new System.Drawing.Size(149, 25);
            this.btn_annulerAnalyseUrl.TabIndex = 5;
            this.btn_annulerAnalyseUrl.Text = "Annuler";
            this.btn_annulerAnalyseUrl.UseVisualStyleBackColor = true;
            // 
            // btn_analyseUrl
            // 
            this.btn_analyseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_analyseUrl.Location = new System.Drawing.Point(861, 0);
            this.btn_analyseUrl.Name = "btn_analyseUrl";
            this.btn_analyseUrl.Size = new System.Drawing.Size(149, 25);
            this.btn_analyseUrl.TabIndex = 4;
            this.btn_analyseUrl.Text = "Analyse URLS";
            this.btn_analyseUrl.UseVisualStyleBackColor = true;
            // 
            // btn_exporte_analyseUrl
            // 
            this.btn_exporte_analyseUrl.Location = new System.Drawing.Point(0, 0);
            this.btn_exporte_analyseUrl.Name = "btn_exporte_analyseUrl";
            this.btn_exporte_analyseUrl.Size = new System.Drawing.Size(133, 25);
            this.btn_exporte_analyseUrl.TabIndex = 3;
            this.btn_exporte_analyseUrl.Text = "Exporte";
            this.btn_exporte_analyseUrl.UseVisualStyleBackColor = true;
            // 
            // list_injectables
            // 
            this.list_injectables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_injectables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader18,
            this.columnHeader17,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader9});
            this.list_injectables.ContextMenuStrip = this.MeunuInjectables;
            this.list_injectables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_injectables.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_injectables.FullRowSelect = true;
            this.list_injectables.GridLines = true;
            this.list_injectables.Location = new System.Drawing.Point(0, 0);
            this.list_injectables.Name = "list_injectables";
            this.list_injectables.Size = new System.Drawing.Size(1010, 400);
            this.list_injectables.TabIndex = 0;
            this.list_injectables.UseCompatibleStateImageBehavior = false;
            this.list_injectables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "URL Point";
            this.columnHeader8.Width = 312;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "SQL User";
            this.columnHeader18.Width = 142;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "SQL Version";
            this.columnHeader17.Width = 141;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "IP";
            this.columnHeader19.Width = 152;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Verifier le";
            this.columnHeader20.Width = 131;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Haut";
            this.columnHeader9.Width = 193;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.splitContainer5);
            this.tabPage8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1016, 435);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Non Vulnerable URL";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btn_exporte_NonVulne);
            this.splitContainer5.Panel1.Controls.Add(this.button8);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.list_non_vulne);
            this.splitContainer5.Size = new System.Drawing.Size(1010, 429);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 2;
            // 
            // btn_exporte_NonVulne
            // 
            this.btn_exporte_NonVulne.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_exporte_NonVulne.Location = new System.Drawing.Point(0, 0);
            this.btn_exporte_NonVulne.Name = "btn_exporte_NonVulne";
            this.btn_exporte_NonVulne.Size = new System.Drawing.Size(147, 25);
            this.btn_exporte_NonVulne.TabIndex = 1;
            this.btn_exporte_NonVulne.Text = "Exporte";
            this.btn_exporte_NonVulne.UseVisualStyleBackColor = true;
            this.btn_exporte_NonVulne.Click += new System.EventHandler(this.btn_exporte_non_vulne);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.Location = new System.Drawing.Point(845, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 25);
            this.button8.TabIndex = 0;
            this.button8.Text = "Nettoyer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_nettoyer_non_vulne);
            // 
            // list_non_vulne
            // 
            this.list_non_vulne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_non_vulne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.list_non_vulne.ContextMenuStrip = this.MenuNonVulne;
            this.list_non_vulne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_non_vulne.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_non_vulne.FullRowSelect = true;
            this.list_non_vulne.GridLines = true;
            this.list_non_vulne.Location = new System.Drawing.Point(0, 0);
            this.list_non_vulne.Name = "list_non_vulne";
            this.list_non_vulne.Size = new System.Drawing.Size(1010, 399);
            this.list_non_vulne.TabIndex = 0;
            this.list_non_vulne.UseCompatibleStateImageBehavior = false;
            this.list_non_vulne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "URL";
            this.columnHeader11.Width = 1071;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.splitContainer6);
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1016, 435);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Scanne PORT";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.chk_urlInjectables);
            this.splitContainer6.Panel1.Controls.Add(this.chk_vulnePort);
            this.splitContainer6.Panel1.Controls.Add(this.chk_trvPort);
            this.splitContainer6.Panel1.Controls.Add(this.btn_infos_scannePort);
            this.splitContainer6.Panel1.Controls.Add(this.btn_scannePort_annuler);
            this.splitContainer6.Panel1.Controls.Add(this.btn_exporte_Portip);
            this.splitContainer6.Panel1.Controls.Add(this.btn_scanne_ip);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.list_scanne_port);
            this.splitContainer6.Size = new System.Drawing.Size(1010, 429);
            this.splitContainer6.SplitterDistance = 83;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 1;
            // 
            // chk_urlInjectables
            // 
            this.chk_urlInjectables.AutoSize = true;
            this.chk_urlInjectables.Checked = true;
            this.chk_urlInjectables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_urlInjectables.Location = new System.Drawing.Point(621, 59);
            this.chk_urlInjectables.Name = "chk_urlInjectables";
            this.chk_urlInjectables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chk_urlInjectables.Size = new System.Drawing.Size(120, 18);
            this.chk_urlInjectables.TabIndex = 7;
            this.chk_urlInjectables.Text = "URL Injectables";
            this.chk_urlInjectables.UseVisualStyleBackColor = true;
            // 
            // chk_vulnePort
            // 
            this.chk_vulnePort.AutoSize = true;
            this.chk_vulnePort.Checked = true;
            this.chk_vulnePort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_vulnePort.Location = new System.Drawing.Point(621, 35);
            this.chk_vulnePort.Name = "chk_vulnePort";
            this.chk_vulnePort.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chk_vulnePort.Size = new System.Drawing.Size(123, 18);
            this.chk_vulnePort.TabIndex = 6;
            this.chk_vulnePort.Text = "URL Vulnerables";
            this.chk_vulnePort.UseVisualStyleBackColor = true;
            // 
            // chk_trvPort
            // 
            this.chk_trvPort.AutoSize = true;
            this.chk_trvPort.Location = new System.Drawing.Point(621, 11);
            this.chk_trvPort.Name = "chk_trvPort";
            this.chk_trvPort.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chk_trvPort.Size = new System.Drawing.Size(104, 18);
            this.chk_trvPort.TabIndex = 5;
            this.chk_trvPort.Text = "URL Trouver";
            this.chk_trvPort.UseVisualStyleBackColor = true;
            // 
            // btn_infos_scannePort
            // 
            this.btn_infos_scannePort.Location = new System.Drawing.Point(157, 3);
            this.btn_infos_scannePort.Name = "btn_infos_scannePort";
            this.btn_infos_scannePort.Size = new System.Drawing.Size(145, 26);
            this.btn_infos_scannePort.TabIndex = 4;
            this.btn_infos_scannePort.Text = "Infos";
            this.btn_infos_scannePort.UseVisualStyleBackColor = true;
            // 
            // btn_scannePort_annuler
            // 
            this.btn_scannePort_annuler.Enabled = false;
            this.btn_scannePort_annuler.Location = new System.Drawing.Point(920, 7);
            this.btn_scannePort_annuler.Name = "btn_scannePort_annuler";
            this.btn_scannePort_annuler.Size = new System.Drawing.Size(85, 26);
            this.btn_scannePort_annuler.TabIndex = 3;
            this.btn_scannePort_annuler.Text = "Annuler";
            this.btn_scannePort_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_exporte_Portip
            // 
            this.btn_exporte_Portip.Location = new System.Drawing.Point(6, 3);
            this.btn_exporte_Portip.Name = "btn_exporte_Portip";
            this.btn_exporte_Portip.Size = new System.Drawing.Size(145, 26);
            this.btn_exporte_Portip.TabIndex = 2;
            this.btn_exporte_Portip.Text = "Exporte";
            this.btn_exporte_Portip.UseVisualStyleBackColor = true;
            this.btn_exporte_Portip.Click += new System.EventHandler(this.btn_exporte_ip_Click);
            // 
            // btn_scanne_ip
            // 
            this.btn_scanne_ip.Location = new System.Drawing.Point(769, 7);
            this.btn_scanne_ip.Name = "btn_scanne_ip";
            this.btn_scanne_ip.Size = new System.Drawing.Size(145, 26);
            this.btn_scanne_ip.TabIndex = 0;
            this.btn_scanne_ip.Text = "Scanne IP";
            this.btn_scanne_ip.UseVisualStyleBackColor = true;
            this.btn_scanne_ip.Click += new System.EventHandler(this.btn_scanne_ip_Click);
            // 
            // list_scanne_port
            // 
            this.list_scanne_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_scanne_port.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader6,
            this.columnHeader16,
            this.columnHeader7});
            this.list_scanne_port.ContextMenuStrip = this.MenuStripPort;
            this.list_scanne_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_scanne_port.FullRowSelect = true;
            this.list_scanne_port.GridLines = true;
            this.list_scanne_port.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_scanne_port.Location = new System.Drawing.Point(0, 0);
            this.list_scanne_port.Name = "list_scanne_port";
            this.list_scanne_port.Size = new System.Drawing.Size(1010, 341);
            this.list_scanne_port.TabIndex = 0;
            this.list_scanne_port.UseCompatibleStateImageBehavior = false;
            this.list_scanne_port.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Hote";
            this.columnHeader12.Width = 370;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "IP";
            this.columnHeader13.Width = 229;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "SSH";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "RDP";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "VNC";
            this.columnHeader6.Width = 62;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "FTP";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 238;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.splitContainer4);
            this.tabPage7.ImageIndex = 1;
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1016, 435);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "URL Crash";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Panel1.Controls.Add(this.button9);
            this.splitContainer4.Panel1.Controls.Add(this.button7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.list_url_trash);
            this.splitContainer4.Size = new System.Drawing.Size(1016, 435);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 25);
            this.button9.TabIndex = 2;
            this.button9.Text = "Exporte";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_exporte_url_trash);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.Location = new System.Drawing.Point(861, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 25);
            this.button7.TabIndex = 0;
            this.button7.Text = "Nettoyer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_nettoyer_url_trash);
            // 
            // list_url_trash
            // 
            this.list_url_trash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.list_url_trash.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.list_url_trash.ContextMenuStrip = this.MenuUrlTrash;
            this.list_url_trash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_url_trash.FullRowSelect = true;
            this.list_url_trash.GridLines = true;
            this.list_url_trash.Location = new System.Drawing.Point(0, 0);
            this.list_url_trash.Name = "list_url_trash";
            this.list_url_trash.Size = new System.Drawing.Size(1016, 405);
            this.list_url_trash.TabIndex = 0;
            this.list_url_trash.UseCompatibleStateImageBehavior = false;
            this.list_url_trash.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "URL";
            this.columnHeader10.Width = 1077;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(655, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 14);
            this.label17.TabIndex = 11;
            this.label17.Text = "URL Port Scanner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageList = this.ImgTab;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL Trouver:";
            // 
            // txt_nbr_nonVulne
            // 
            this.txt_nbr_nonVulne.AutoSize = true;
            this.txt_nbr_nonVulne.BackColor = System.Drawing.Color.Snow;
            this.txt_nbr_nonVulne.Location = new System.Drawing.Point(593, 6);
            this.txt_nbr_nonVulne.Name = "txt_nbr_nonVulne";
            this.txt_nbr_nonVulne.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.txt_nbr_nonVulne.Size = new System.Drawing.Size(35, 14);
            this.txt_nbr_nonVulne.TabIndex = 8;
            this.txt_nbr_nonVulne.Text = "0     ";
            // 
            // txt_nbr_injectable
            // 
            this.txt_nbr_injectable.AutoSize = true;
            this.txt_nbr_injectable.BackColor = System.Drawing.Color.Snow;
            this.txt_nbr_injectable.Location = new System.Drawing.Point(408, 8);
            this.txt_nbr_injectable.Name = "txt_nbr_injectable";
            this.txt_nbr_injectable.Size = new System.Drawing.Size(34, 14);
            this.txt_nbr_injectable.TabIndex = 10;
            this.txt_nbr_injectable.Text = "0     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "URL No vulnerable:";
            // 
            // txt_nbr_trouver
            // 
            this.txt_nbr_trouver.AutoSize = true;
            this.txt_nbr_trouver.BackColor = System.Drawing.Color.Snow;
            this.txt_nbr_trouver.Location = new System.Drawing.Point(98, 8);
            this.txt_nbr_trouver.Name = "txt_nbr_trouver";
            this.txt_nbr_trouver.Size = new System.Drawing.Size(34, 14);
            this.txt_nbr_trouver.TabIndex = 9;
            this.txt_nbr_trouver.Text = "0     ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "URL Vunerable:";
            // 
            // txt_nbr_vulne
            // 
            this.txt_nbr_vulne.AutoSize = true;
            this.txt_nbr_vulne.BackColor = System.Drawing.Color.Snow;
            this.txt_nbr_vulne.Location = new System.Drawing.Point(255, 6);
            this.txt_nbr_vulne.Name = "txt_nbr_vulne";
            this.txt_nbr_vulne.Size = new System.Drawing.Size(34, 14);
            this.txt_nbr_vulne.TabIndex = 7;
            this.txt_nbr_vulne.Text = "0     ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "URL Injectables:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.splitContainer7);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1020, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyse URL";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer7.Panel1.Controls.Add(this.txt_statut_analyse);
            this.splitContainer7.Panel1.Controls.Add(this.btn_annuller_AnaUrl);
            this.splitContainer7.Panel1.Controls.Add(this.btn_stop_analyse_url);
            this.splitContainer7.Panel1.Controls.Add(this.button1);
            this.splitContainer7.Panel1.Controls.Add(this.btn_demmarer_analyse_url);
            this.splitContainer7.Panel1.Controls.Add(this.txt_url_analyse);
            this.splitContainer7.Panel1.Controls.Add(this.label1);
            this.splitContainer7.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer7.Panel2.Controls.Add(this.groupInfoAnaluse);
            this.splitContainer7.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer7.Size = new System.Drawing.Size(1014, 483);
            this.splitContainer7.SplitterDistance = 286;
            this.splitContainer7.SplitterWidth = 5;
            this.splitContainer7.TabIndex = 9;
            // 
            // txt_statut_analyse
            // 
            this.txt_statut_analyse.AutoSize = true;
            this.txt_statut_analyse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statut_analyse.Location = new System.Drawing.Point(11, 356);
            this.txt_statut_analyse.Name = "txt_statut_analyse";
            this.txt_statut_analyse.Size = new System.Drawing.Size(56, 16);
            this.txt_statut_analyse.TabIndex = 16;
            this.txt_statut_analyse.Text = "            ";
            // 
            // btn_annuller_AnaUrl
            // 
            this.btn_annuller_AnaUrl.BackColor = System.Drawing.Color.Red;
            this.btn_annuller_AnaUrl.Location = new System.Drawing.Point(399, 104);
            this.btn_annuller_AnaUrl.Name = "btn_annuller_AnaUrl";
            this.btn_annuller_AnaUrl.Size = new System.Drawing.Size(126, 36);
            this.btn_annuller_AnaUrl.TabIndex = 15;
            this.btn_annuller_AnaUrl.Text = "Annuler";
            this.btn_annuller_AnaUrl.UseVisualStyleBackColor = false;
            this.btn_annuller_AnaUrl.Click += new System.EventHandler(this.btn_annuler_analyse_url_Click);
            // 
            // btn_stop_analyse_url
            // 
            this.btn_stop_analyse_url.BackColor = System.Drawing.Color.Red;
            this.btn_stop_analyse_url.Location = new System.Drawing.Point(399, 104);
            this.btn_stop_analyse_url.Name = "btn_stop_analyse_url";
            this.btn_stop_analyse_url.Size = new System.Drawing.Size(126, 36);
            this.btn_stop_analyse_url.TabIndex = 15;
            this.btn_stop_analyse_url.Text = "Arreter";
            this.btn_stop_analyse_url.UseVisualStyleBackColor = false;
            this.btn_stop_analyse_url.Click += new System.EventHandler(this.btn_annuler_analyse_url_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(540, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Demmarer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_demmarer_analyse_url_Click);
            // 
            // btn_demmarer_analyse_url
            // 
            this.btn_demmarer_analyse_url.BackColor = System.Drawing.Color.Green;
            this.btn_demmarer_analyse_url.Location = new System.Drawing.Point(540, 104);
            this.btn_demmarer_analyse_url.Name = "btn_demmarer_analyse_url";
            this.btn_demmarer_analyse_url.Size = new System.Drawing.Size(126, 36);
            this.btn_demmarer_analyse_url.TabIndex = 12;
            this.btn_demmarer_analyse_url.Text = "Demmarer";
            this.btn_demmarer_analyse_url.UseVisualStyleBackColor = false;
            this.btn_demmarer_analyse_url.Click += new System.EventHandler(this.btn_demmarer_analyse_url_Click);
            // 
            // txt_url_analyse
            // 
            this.txt_url_analyse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url_analyse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_url_analyse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txt_url_analyse.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQl_SCanner.Properties.Settings.Default, "UrlAnalyse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_url_analyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_url_analyse.Location = new System.Drawing.Point(45, 7);
            this.txt_url_analyse.Name = "txt_url_analyse";
            this.txt_url_analyse.Size = new System.Drawing.Size(956, 20);
            this.txt_url_analyse.TabIndex = 13;
            this.txt_url_analyse.Text = global::SQl_SCanner.Properties.Settings.Default.UrlAnalyse;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL:";
            // 
            // groupInfoAnaluse
            // 
            this.groupInfoAnaluse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfoAnaluse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupInfoAnaluse.Controls.Add(this.txt_LoadFileAnalyse);
            this.groupInfoAnaluse.Controls.Add(this.label13);
            this.groupInfoAnaluse.Controls.Add(this.txt_urlPointSucces);
            this.groupInfoAnaluse.Controls.Add(this.label8);
            this.groupInfoAnaluse.Controls.Add(this.btn_aller_dump);
            this.groupInfoAnaluse.Controls.Add(this.txt_versionAnalyse);
            this.groupInfoAnaluse.Controls.Add(this.txt_userAnalyse);
            this.groupInfoAnaluse.Controls.Add(this.txt_ipAnalyse);
            this.groupInfoAnaluse.Controls.Add(this.label18);
            this.groupInfoAnaluse.Controls.Add(this.label19);
            this.groupInfoAnaluse.Controls.Add(this.label20);
            this.groupInfoAnaluse.Location = new System.Drawing.Point(3, 3);
            this.groupInfoAnaluse.Name = "groupInfoAnaluse";
            this.groupInfoAnaluse.Size = new System.Drawing.Size(1008, 165);
            this.groupInfoAnaluse.TabIndex = 22;
            this.groupInfoAnaluse.TabStop = false;
            this.groupInfoAnaluse.Text = "Infos:";
            // 
            // txt_LoadFileAnalyse
            // 
            this.txt_LoadFileAnalyse.AutoSize = true;
            this.txt_LoadFileAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_LoadFileAnalyse.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_LoadFileAnalyse.Location = new System.Drawing.Point(96, 65);
            this.txt_LoadFileAnalyse.Name = "txt_LoadFileAnalyse";
            this.txt_LoadFileAnalyse.Size = new System.Drawing.Size(29, 17);
            this.txt_LoadFileAnalyse.TabIndex = 31;
            this.txt_LoadFileAnalyse.Text = "       ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "Load File:";
            // 
            // txt_urlPointSucces
            // 
            this.txt_urlPointSucces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_urlPointSucces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_urlPointSucces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txt_urlPointSucces.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQl_SCanner.Properties.Settings.Default, "UrlAnalyse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_urlPointSucces.Enabled = false;
            this.txt_urlPointSucces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_urlPointSucces.Location = new System.Drawing.Point(75, 143);
            this.txt_urlPointSucces.Name = "txt_urlPointSucces";
            this.txt_urlPointSucces.Size = new System.Drawing.Size(791, 20);
            this.txt_urlPointSucces.TabIndex = 28;
            this.txt_urlPointSucces.Text = global::SQl_SCanner.Properties.Settings.Default.UrlAnalyse;
            this.txt_urlPointSucces.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "URl Point:";
            this.label8.Visible = false;
            // 
            // btn_aller_dump
            // 
            this.btn_aller_dump.BackColor = System.Drawing.Color.Green;
            this.btn_aller_dump.Location = new System.Drawing.Point(872, 138);
            this.btn_aller_dump.Name = "btn_aller_dump";
            this.btn_aller_dump.Size = new System.Drawing.Size(130, 28);
            this.btn_aller_dump.TabIndex = 27;
            this.btn_aller_dump.Text = "Dump Data";
            this.btn_aller_dump.UseVisualStyleBackColor = false;
            this.btn_aller_dump.Visible = false;
            this.btn_aller_dump.Click += new System.EventHandler(this.btn_aller_dump_Click);
            // 
            // txt_versionAnalyse
            // 
            this.txt_versionAnalyse.AutoSize = true;
            this.txt_versionAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_versionAnalyse.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_versionAnalyse.Location = new System.Drawing.Point(86, 20);
            this.txt_versionAnalyse.Name = "txt_versionAnalyse";
            this.txt_versionAnalyse.Size = new System.Drawing.Size(32, 17);
            this.txt_versionAnalyse.TabIndex = 26;
            this.txt_versionAnalyse.Text = "        ";
            // 
            // txt_userAnalyse
            // 
            this.txt_userAnalyse.AutoSize = true;
            this.txt_userAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_userAnalyse.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_userAnalyse.Location = new System.Drawing.Point(425, 20);
            this.txt_userAnalyse.Name = "txt_userAnalyse";
            this.txt_userAnalyse.Size = new System.Drawing.Size(26, 17);
            this.txt_userAnalyse.TabIndex = 25;
            this.txt_userAnalyse.Text = "      ";
            // 
            // txt_ipAnalyse
            // 
            this.txt_ipAnalyse.AutoSize = true;
            this.txt_ipAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_ipAnalyse.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_ipAnalyse.Location = new System.Drawing.Point(829, 20);
            this.txt_ipAnalyse.Name = "txt_ipAnalyse";
            this.txt_ipAnalyse.Size = new System.Drawing.Size(29, 17);
            this.txt_ipAnalyse.TabIndex = 20;
            this.txt_ipAnalyse.Text = "       ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(803, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 14);
            this.label18.TabIndex = 19;
            this.label18.Text = "IP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(380, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 14);
            this.label19.TabIndex = 18;
            this.label19.Text = "Users:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 14);
            this.label20.TabIndex = 17;
            this.label20.Text = "Version:";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.splitContainer9);
            this.tabPage10.Location = new System.Drawing.Point(4, 26);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1020, 489);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "Dumper";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.splitContainer10);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.panel1);
            this.splitContainer9.Size = new System.Drawing.Size(1020, 489);
            this.splitContainer9.SplitterDistance = 286;
            this.splitContainer9.SplitterWidth = 5;
            this.splitContainer9.TabIndex = 0;
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer10.Panel1.Controls.Add(this.label11);
            this.splitContainer10.Panel1.Controls.Add(this.txt_url_dmp);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(1020, 286);
            this.splitContainer10.SplitterDistance = 57;
            this.splitContainer10.SplitterWidth = 5;
            this.splitContainer10.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txt_version);
            this.groupBox4.Controls.Add(this.txt_user);
            this.groupBox4.Controls.Add(this.txt_ipserveur);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(8, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 28);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Infos:";
            // 
            // txt_version
            // 
            this.txt_version.AutoSize = true;
            this.txt_version.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_version.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_version.Location = new System.Drawing.Point(90, 12);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(32, 17);
            this.txt_version.TabIndex = 26;
            this.txt_version.Text = "        ";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_user.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_user.Location = new System.Drawing.Point(429, 12);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(26, 17);
            this.txt_user.TabIndex = 25;
            this.txt_user.Text = "      ";
            // 
            // txt_ipserveur
            // 
            this.txt_ipserveur.AutoSize = true;
            this.txt_ipserveur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_ipserveur.Font = new System.Drawing.Font("Calibri", 10.105F);
            this.txt_ipserveur.Location = new System.Drawing.Point(833, 12);
            this.txt_ipserveur.Name = "txt_ipserveur";
            this.txt_ipserveur.Size = new System.Drawing.Size(29, 17);
            this.txt_ipserveur.TabIndex = 20;
            this.txt_ipserveur.Text = "       ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(803, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 14);
            this.label14.TabIndex = 19;
            this.label14.Text = "IP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 14);
            this.label15.TabIndex = 18;
            this.label15.Text = "Users:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 14);
            this.label16.TabIndex = 17;
            this.label16.Text = "Version:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "URL Point:";
            // 
            // txt_url_dmp
            // 
            this.txt_url_dmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url_dmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQl_SCanner.Properties.Settings.Default, "UrlDump", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_url_dmp.Location = new System.Drawing.Point(87, 3);
            this.txt_url_dmp.Name = "txt_url_dmp";
            this.txt_url_dmp.Size = new System.Drawing.Size(925, 22);
            this.txt_url_dmp.TabIndex = 0;
            this.txt_url_dmp.Text = global::SQl_SCanner.Properties.Settings.Default.UrlDump;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.splitContainer12);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.btn_start_dmp);
            this.splitContainer11.Panel2.Controls.Add(this.btn_annuler_dmp);
            this.splitContainer11.Panel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQl_SCanner.Properties.Settings.Default, "UrlDump", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer11.Panel2.Text = global::SQl_SCanner.Properties.Settings.Default.UrlDump;
            this.splitContainer11.Size = new System.Drawing.Size(1020, 224);
            this.splitContainer11.SplitterDistance = 722;
            this.splitContainer11.TabIndex = 0;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            this.splitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.btn_get_donne);
            this.splitContainer12.Panel1.Controls.Add(this.btn_get_colonne);
            this.splitContainer12.Panel1.Controls.Add(this.btn_get_tables);
            this.splitContainer12.Panel1.Controls.Add(this.btn_get_dbs);
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.tree_schema_dmp);
            this.splitContainer12.Size = new System.Drawing.Size(722, 224);
            this.splitContainer12.SplitterDistance = 30;
            this.splitContainer12.SplitterWidth = 5;
            this.splitContainer12.TabIndex = 0;
            // 
            // btn_get_donne
            // 
            this.btn_get_donne.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_get_donne.Location = new System.Drawing.Point(293, 3);
            this.btn_get_donne.Name = "btn_get_donne";
            this.btn_get_donne.Size = new System.Drawing.Size(75, 23);
            this.btn_get_donne.TabIndex = 12;
            this.btn_get_donne.Text = "Get Data";
            this.btn_get_donne.UseVisualStyleBackColor = false;
            this.btn_get_donne.Click += new System.EventHandler(this.btn_get_donne_Click);
            // 
            // btn_get_colonne
            // 
            this.btn_get_colonne.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_get_colonne.Location = new System.Drawing.Point(187, 4);
            this.btn_get_colonne.Name = "btn_get_colonne";
            this.btn_get_colonne.Size = new System.Drawing.Size(100, 23);
            this.btn_get_colonne.TabIndex = 11;
            this.btn_get_colonne.Text = "Get Colonne";
            this.btn_get_colonne.UseVisualStyleBackColor = false;
            this.btn_get_colonne.Click += new System.EventHandler(this.btn_get_colonne_Click);
            // 
            // btn_get_tables
            // 
            this.btn_get_tables.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_get_tables.Location = new System.Drawing.Point(87, 4);
            this.btn_get_tables.Name = "btn_get_tables";
            this.btn_get_tables.Size = new System.Drawing.Size(94, 23);
            this.btn_get_tables.TabIndex = 10;
            this.btn_get_tables.Text = "Get Table";
            this.btn_get_tables.UseVisualStyleBackColor = false;
            this.btn_get_tables.Click += new System.EventHandler(this.btn_get_tables_Click);
            // 
            // btn_get_dbs
            // 
            this.btn_get_dbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_get_dbs.Location = new System.Drawing.Point(6, 4);
            this.btn_get_dbs.Name = "btn_get_dbs";
            this.btn_get_dbs.Size = new System.Drawing.Size(75, 23);
            this.btn_get_dbs.TabIndex = 9;
            this.btn_get_dbs.Text = "Get DB";
            this.btn_get_dbs.UseVisualStyleBackColor = false;
            this.btn_get_dbs.Click += new System.EventHandler(this.btn_get_dbs_Click);
            // 
            // tree_schema_dmp
            // 
            this.tree_schema_dmp.CheckBoxes = true;
            this.tree_schema_dmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_schema_dmp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tree_schema_dmp.Location = new System.Drawing.Point(0, 0);
            this.tree_schema_dmp.Name = "tree_schema_dmp";
            this.tree_schema_dmp.ShowNodeToolTips = true;
            this.tree_schema_dmp.Size = new System.Drawing.Size(722, 189);
            this.tree_schema_dmp.TabIndex = 0;
            this.tree_schema_dmp.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_schema_dmp_AfterCheck);
            this.tree_schema_dmp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_schema_dmp_AfterSelect);
            this.tree_schema_dmp.DoubleClick += new System.EventHandler(this.tree_schema_dmp_DoubleClick);
            // 
            // btn_start_dmp
            // 
            this.btn_start_dmp.Location = new System.Drawing.Point(24, 22);
            this.btn_start_dmp.Name = "btn_start_dmp";
            this.btn_start_dmp.Size = new System.Drawing.Size(143, 31);
            this.btn_start_dmp.TabIndex = 5;
            this.btn_start_dmp.Text = "Demmarer";
            this.btn_start_dmp.UseVisualStyleBackColor = true;
            this.btn_start_dmp.Click += new System.EventHandler(this.btn_start_dmp_Click);
            // 
            // btn_annuler_dmp
            // 
            this.btn_annuler_dmp.Enabled = false;
            this.btn_annuler_dmp.Location = new System.Drawing.Point(173, 22);
            this.btn_annuler_dmp.Name = "btn_annuler_dmp";
            this.btn_annuler_dmp.Size = new System.Drawing.Size(114, 31);
            this.btn_annuler_dmp.TabIndex = 2;
            this.btn_annuler_dmp.Text = "Annuler";
            this.btn_annuler_dmp.UseVisualStyleBackColor = true;
            this.btn_annuler_dmp.Click += new System.EventHandler(this.btn_annuler_dmp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_dumper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 198);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_dumper
            // 
            this.dataGridView_dumper.AllowUserToAddRows = false;
            this.dataGridView_dumper.AllowUserToDeleteRows = false;
            this.dataGridView_dumper.AllowUserToOrderColumns = true;
            this.dataGridView_dumper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_dumper.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_dumper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dumper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dumper.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_dumper.Name = "dataGridView_dumper";
            this.dataGridView_dumper.ReadOnly = true;
            this.dataGridView_dumper.Size = new System.Drawing.Size(1020, 198);
            this.dataGridView_dumper.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2MinSize = 10;
            this.splitContainer2.Size = new System.Drawing.Size(1028, 549);
            this.splitContainer2.SplitterDistance = 519;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 571);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.105F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuadCore SQli Injecter V1.0 Build 2016";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripUrl.ResumeLayout(false);
            this.MenuStripVulne.ResumeLayout(false);
            this.MenuStripPort.ResumeLayout(false);
            this.MeunuInjectables.ResumeLayout(false);
            this.MenuNonVulne.ResumeLayout(false);
            this.MenuUrlTrash.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbrPage_txt)).EndInit();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.splitContainer13.Panel1.ResumeLayout(false);
            this.splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).EndInit();
            this.splitContainer13.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupInfoAnaluse.ResumeLayout(false);
            this.groupInfoAnaluse.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dumper)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void demmare_btn_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripUrl;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel fait_txt;
        private System.Windows.Forms.ContextMenuStrip MenuStripVulne;
        private System.Windows.Forms.ToolStripMenuItem suprimmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip MenuUrlTrash;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip MenuNonVulne;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nettoyéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nettoyéToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nettoyéToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nettoyéToolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel txt_monip;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.ContextMenuStrip MenuStripPort;
        private System.Windows.Forms.ToolStripMenuItem copierPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nettoyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierHoteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MeunuInjectables;
        private System.Windows.Forms.ToolStripMenuItem copierURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimmerToutToolStripMenuItem;
        private System.Windows.Forms.ImageList ImgTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.SplitContainer splitContainer7;
        internal System.Windows.Forms.Label txt_statut_analyse;
        private System.Windows.Forms.Button btn_annuller_AnaUrl;
        private System.Windows.Forms.Button btn_stop_analyse_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_demmarer_analyse_url;
        public System.Windows.Forms.TextBox txt_url_analyse;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox groupInfoAnaluse;
        internal System.Windows.Forms.Label txt_LoadFileAnalyse;
        public System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txt_urlPointSucces;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btn_aller_dump;
        public System.Windows.Forms.Label txt_versionAnalyse;
        public System.Windows.Forms.Label txt_userAnalyse;
        public System.Windows.Forms.Label txt_ipAnalyse;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.SplitContainer splitContainer10;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label txt_version;
        public System.Windows.Forms.Label txt_user;
        public System.Windows.Forms.Label txt_ipserveur;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_url_dmp;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.SplitContainer splitContainer12;
        public System.Windows.Forms.TreeView tree_schema_dmp;
        private System.Windows.Forms.Button btn_annuler_dmp;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView_dumper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_get_donne;
        private System.Windows.Forms.Button btn_get_colonne;
        private System.Windows.Forms.Button btn_get_tables;
        private System.Windows.Forms.Button btn_get_dbs;
        private System.Windows.Forms.Button btn_start_dmp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txt_nbr_scannePort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txt_nbr_injectable;
        private System.Windows.Forms.Label txt_nbr_trouver;
        private System.Windows.Forms.Label txt_nbr_nonVulne;
        private System.Windows.Forms.Label txt_nbr_vulne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.TextBox txt_recherche_infos;
        internal System.Windows.Forms.ListView list_url;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_scanne_url_annuler;
        private System.Windows.Forms.Button btn_scanneListeUrls;
        private System.Windows.Forms.Button btn_exporte_vulne;
        public System.Windows.Forms.ListView list_vulne;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer13;
        private System.Windows.Forms.Button btn_annulerAnalyseUrl;
        private System.Windows.Forms.Button btn_analyseUrl;
        private System.Windows.Forms.Button btn_exporte_analyseUrl;
        internal System.Windows.Forms.ListView list_injectables;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button btn_exporte_NonVulne;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.ListView list_non_vulne;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.CheckBox chk_urlInjectables;
        private System.Windows.Forms.CheckBox chk_vulnePort;
        private System.Windows.Forms.CheckBox chk_trvPort;
        private System.Windows.Forms.Button btn_infos_scannePort;
        private System.Windows.Forms.Button btn_scannePort_annuler;
        private System.Windows.Forms.Button btn_exporte_Portip;
        private System.Windows.Forms.Button btn_scanne_ip;
        public System.Windows.Forms.ListView list_scanne_port;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.ListView list_url_trash;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btn_nettoyer_url;
        private System.Windows.Forms.Button btn_exporte;
        private System.Windows.Forms.Button btn_importe_url;
        private System.Windows.Forms.TextBox txt_dorks;
        private System.Windows.Forms.CheckBox chk_aol;
        private System.Windows.Forms.CheckBox chk_yahoo;
        private System.Windows.Forms.CheckBox chk_yandex;
        private System.Windows.Forms.CheckBox chk_bing;
        private System.Windows.Forms.CheckBox chk_google;
        private System.Windows.Forms.Button btn_stop;
        internal System.Windows.Forms.NumericUpDown nbrPage_txt;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Label label7;

    }
}

