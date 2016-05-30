namespace PM4P
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Runbtn = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnWindowWithOnePassLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnWindowWithTwoPassLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setcolorofbackground = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorDataWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColoTextRunButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundRunButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorNameOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundTwoLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorNameTwoLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersTwoLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takingDataFromWebSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1251ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1252ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1253ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1254ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1255ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows1257ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSSYNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSByURIIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSUDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSByHTTPReqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webSpoofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailSpoofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twolimitsbox = new System.Windows.Forms.TextBox();
            this.onelimitbox = new System.Windows.Forms.TextBox();
            this.onelimitLbl = new System.Windows.Forms.Label();
            this.twolimitsLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LinktxtBox = new System.Windows.Forms.TextBox();
            this.Linklbl = new System.Windows.Forms.Label();
            this.URLTargettxtbox = new System.Windows.Forms.TextBox();
            this.targetlbl = new System.Windows.Forms.Label();
            this.IPlbl = new System.Windows.Forms.Label();
            this.iptxtbox = new System.Windows.Forms.TextBox();
            this.portlbl = new System.Windows.Forms.Label();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.pathfilelbl = new System.Windows.Forms.Label();
            this.pathfiletxtbox = new System.Windows.Forms.TextBox();
            this.URLtxtbox2 = new System.Windows.Forms.TextBox();
            this.URLtrgtlbl = new System.Windows.Forms.Label();
            this.IPSYNATTlbl = new System.Windows.Forms.Label();
            this.IPSYNATTtxtbox = new System.Windows.Forms.TextBox();
            this.PORTSYNATTlbl = new System.Windows.Forms.Label();
            this.PORTSYNATTtxtbox = new System.Windows.Forms.TextBox();
            this.lbllinkcp = new System.Windows.Forms.Label();
            this.txtbxcplink = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Runbtn
            // 
            this.Runbtn.Location = new System.Drawing.Point(678, 31);
            this.Runbtn.Name = "Runbtn";
            this.Runbtn.Size = new System.Drawing.Size(92, 39);
            this.Runbtn.TabIndex = 0;
            this.Runbtn.Text = "Run";
            this.Runbtn.UseVisualStyleBackColor = true;
            this.Runbtn.Click += new System.EventHandler(this.Runbtn_Click);
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(12, 76);
            this.dane.Multiline = true;
            this.dane.Name = "dane";
            this.dane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dane.Size = new System.Drawing.Size(758, 467);
            this.dane.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.encodingToolStripMenuItem,
            this.attackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnWindowWithOnePassLimitToolStripMenuItem,
            this.turnWindowWithTwoPassLimitsToolStripMenuItem,
            this.runToolStripMenuItem,
            this.setColorToolStripMenuItem,
            this.saveSessionToolStripMenuItem,
            this.takingDataFromWebSiteToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // turnWindowWithOnePassLimitToolStripMenuItem
            // 
            this.turnWindowWithOnePassLimitToolStripMenuItem.Name = "turnWindowWithOnePassLimitToolStripMenuItem";
            this.turnWindowWithOnePassLimitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.turnWindowWithOnePassLimitToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.turnWindowWithOnePassLimitToolStripMenuItem.Text = "Turn on Window with one pass limit";
            this.turnWindowWithOnePassLimitToolStripMenuItem.Click += new System.EventHandler(this.turnWindowWithOnePassLimitToolStripMenuItem_Click);
            // 
            // turnWindowWithTwoPassLimitsToolStripMenuItem
            // 
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Name = "turnWindowWithTwoPassLimitsToolStripMenuItem";
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Text = "Turn on Window with two pass limits";
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Click += new System.EventHandler(this.turnWindowWithTwoPassLimitsToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.runToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setcolorofbackground,
            this.setColorDataWindowToolStripMenuItem,
            this.setColorCharactersToolStripMenuItem,
            this.setColoTextRunButtonToolStripMenuItem,
            this.setBackgroundRunButtonToolStripMenuItem,
            this.setBackgroundOneLimitToolStripMenuItem,
            this.setColorNameOneLimitToolStripMenuItem,
            this.setColorCharactersOneLimitToolStripMenuItem,
            this.setBackgroundTwoLimitsToolStripMenuItem,
            this.setColorNameTwoLimitToolStripMenuItem,
            this.setColorCharactersTwoLimitsToolStripMenuItem});
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.setColorToolStripMenuItem.Text = "Set Color";
            // 
            // setcolorofbackground
            // 
            this.setcolorofbackground.Name = "setcolorofbackground";
            this.setcolorofbackground.Size = new System.Drawing.Size(305, 26);
            this.setcolorofbackground.Text = "Set Color Background";
            this.setcolorofbackground.Click += new System.EventHandler(this.setcolorofbackground_Click);
            // 
            // setColorDataWindowToolStripMenuItem
            // 
            this.setColorDataWindowToolStripMenuItem.Name = "setColorDataWindowToolStripMenuItem";
            this.setColorDataWindowToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorDataWindowToolStripMenuItem.Text = "Set Color Data Window";
            this.setColorDataWindowToolStripMenuItem.Click += new System.EventHandler(this.setColorDataWindowToolStripMenuItem_Click);
            // 
            // setColorCharactersToolStripMenuItem
            // 
            this.setColorCharactersToolStripMenuItem.Name = "setColorCharactersToolStripMenuItem";
            this.setColorCharactersToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersToolStripMenuItem.Text = "Set Color Characters";
            this.setColorCharactersToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersToolStripMenuItem_Click);
            // 
            // setColoTextRunButtonToolStripMenuItem
            // 
            this.setColoTextRunButtonToolStripMenuItem.Name = "setColoTextRunButtonToolStripMenuItem";
            this.setColoTextRunButtonToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColoTextRunButtonToolStripMenuItem.Text = "Set Color Text \"Run\" Button";
            this.setColoTextRunButtonToolStripMenuItem.Click += new System.EventHandler(this.setColoTextRunButtonToolStripMenuItem_Click);
            // 
            // setBackgroundRunButtonToolStripMenuItem
            // 
            this.setBackgroundRunButtonToolStripMenuItem.Name = "setBackgroundRunButtonToolStripMenuItem";
            this.setBackgroundRunButtonToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundRunButtonToolStripMenuItem.Text = "Set Background \"Run\" Button";
            this.setBackgroundRunButtonToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundRunButtonToolStripMenuItem_Click);
            // 
            // setBackgroundOneLimitToolStripMenuItem
            // 
            this.setBackgroundOneLimitToolStripMenuItem.Name = "setBackgroundOneLimitToolStripMenuItem";
            this.setBackgroundOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundOneLimitToolStripMenuItem.Text = "Set Background One Limit";
            this.setBackgroundOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundOneLimitToolStripMenuItem_Click);
            // 
            // setColorNameOneLimitToolStripMenuItem
            // 
            this.setColorNameOneLimitToolStripMenuItem.Name = "setColorNameOneLimitToolStripMenuItem";
            this.setColorNameOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorNameOneLimitToolStripMenuItem.Text = "Set Color Name One Limit";
            this.setColorNameOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorNameOneLimitToolStripMenuItem_Click);
            // 
            // setColorCharactersOneLimitToolStripMenuItem
            // 
            this.setColorCharactersOneLimitToolStripMenuItem.Name = "setColorCharactersOneLimitToolStripMenuItem";
            this.setColorCharactersOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersOneLimitToolStripMenuItem.Text = "Set Color Characters \"One Limit\"";
            this.setColorCharactersOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersOneLimitToolStripMenuItem_Click);
            // 
            // setBackgroundTwoLimitsToolStripMenuItem
            // 
            this.setBackgroundTwoLimitsToolStripMenuItem.Name = "setBackgroundTwoLimitsToolStripMenuItem";
            this.setBackgroundTwoLimitsToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundTwoLimitsToolStripMenuItem.Text = "Set Background Two Limits";
            this.setBackgroundTwoLimitsToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundTwoLimitsToolStripMenuItem_Click);
            // 
            // setColorNameTwoLimitToolStripMenuItem
            // 
            this.setColorNameTwoLimitToolStripMenuItem.Name = "setColorNameTwoLimitToolStripMenuItem";
            this.setColorNameTwoLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorNameTwoLimitToolStripMenuItem.Text = "Set Color Name Two Limit";
            this.setColorNameTwoLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorNameTwoLimitToolStripMenuItem_Click);
            // 
            // setColorCharactersTwoLimitsToolStripMenuItem
            // 
            this.setColorCharactersTwoLimitsToolStripMenuItem.Name = "setColorCharactersTwoLimitsToolStripMenuItem";
            this.setColorCharactersTwoLimitsToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersTwoLimitsToolStripMenuItem.Text = "Set Color Characters \"Two Limits\"";
            this.setColorCharactersTwoLimitsToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersTwoLimitsToolStripMenuItem_Click);
            // 
            // saveSessionToolStripMenuItem
            // 
            this.saveSessionToolStripMenuItem.Name = "saveSessionToolStripMenuItem";
            this.saveSessionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.saveSessionToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.saveSessionToolStripMenuItem.Text = "Save Session";
            this.saveSessionToolStripMenuItem.Click += new System.EventHandler(this.saveSessionToolStripMenuItem_Click);
            // 
            // takingDataFromWebSiteToolStripMenuItem
            // 
            this.takingDataFromWebSiteToolStripMenuItem.Name = "takingDataFromWebSiteToolStripMenuItem";
            this.takingDataFromWebSiteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.takingDataFromWebSiteToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.takingDataFromWebSiteToolStripMenuItem.Text = "Taking Data from WebSite";
            this.takingDataFromWebSiteToolStripMenuItem.Click += new System.EventHandler(this.takingDataFromWebSiteToolStripMenuItem_Click);
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8ToolStripMenuItem,
            this.windows1251ToolStripMenuItem,
            this.windows1252ToolStripMenuItem,
            this.windows1253ToolStripMenuItem,
            this.windows1254ToolStripMenuItem,
            this.windows1255ToolStripMenuItem,
            this.windows1256ToolStripMenuItem,
            this.windows1257ToolStripMenuItem});
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.encodingToolStripMenuItem.Text = "Encoding";
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.uTF8ToolStripMenuItem.Text = "Middle Europe Lang";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // windows1251ToolStripMenuItem
            // 
            this.windows1251ToolStripMenuItem.Name = "windows1251ToolStripMenuItem";
            this.windows1251ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1251ToolStripMenuItem.Text = "Cyrilic";
            this.windows1251ToolStripMenuItem.Click += new System.EventHandler(this.windows1251ToolStripMenuItem_Click);
            // 
            // windows1252ToolStripMenuItem
            // 
            this.windows1252ToolStripMenuItem.Name = "windows1252ToolStripMenuItem";
            this.windows1252ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1252ToolStripMenuItem.Text = "Western Lang";
            this.windows1252ToolStripMenuItem.Click += new System.EventHandler(this.windows1252ToolStripMenuItem_Click);
            // 
            // windows1253ToolStripMenuItem
            // 
            this.windows1253ToolStripMenuItem.Name = "windows1253ToolStripMenuItem";
            this.windows1253ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1253ToolStripMenuItem.Text = "Greek";
            this.windows1253ToolStripMenuItem.Click += new System.EventHandler(this.windows1253ToolStripMenuItem_Click);
            // 
            // windows1254ToolStripMenuItem
            // 
            this.windows1254ToolStripMenuItem.Name = "windows1254ToolStripMenuItem";
            this.windows1254ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1254ToolStripMenuItem.Text = "Turkish";
            this.windows1254ToolStripMenuItem.Click += new System.EventHandler(this.windows1254ToolStripMenuItem_Click);
            // 
            // windows1255ToolStripMenuItem
            // 
            this.windows1255ToolStripMenuItem.Name = "windows1255ToolStripMenuItem";
            this.windows1255ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1255ToolStripMenuItem.Text = "Hebrew";
            this.windows1255ToolStripMenuItem.Click += new System.EventHandler(this.windows1255ToolStripMenuItem_Click);
            // 
            // windows1256ToolStripMenuItem
            // 
            this.windows1256ToolStripMenuItem.Name = "windows1256ToolStripMenuItem";
            this.windows1256ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1256ToolStripMenuItem.Text = "Arabic";
            this.windows1256ToolStripMenuItem.Click += new System.EventHandler(this.windows1256ToolStripMenuItem_Click);
            // 
            // windows1257ToolStripMenuItem
            // 
            this.windows1257ToolStripMenuItem.Name = "windows1257ToolStripMenuItem";
            this.windows1257ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.windows1257ToolStripMenuItem.Text = "Baltic Lang";
            this.windows1257ToolStripMenuItem.Click += new System.EventHandler(this.windows1257ToolStripMenuItem_Click);
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doSToolStripMenuItem,
            this.doSSYNToolStripMenuItem,
            this.doSByURIIDToolStripMenuItem,
            this.doSUDPToolStripMenuItem,
            this.doSByHTTPReqToolStripMenuItem,
            this.webSpoofingToolStripMenuItem,
            this.emailSpoofingToolStripMenuItem});
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.attackToolStripMenuItem.Text = "Attack";
            // 
            // doSToolStripMenuItem
            // 
            this.doSToolStripMenuItem.Name = "doSToolStripMenuItem";
            this.doSToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doSToolStripMenuItem.Text = "DoS";
            // 
            // doSSYNToolStripMenuItem
            // 
            this.doSSYNToolStripMenuItem.Name = "doSSYNToolStripMenuItem";
            this.doSSYNToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doSSYNToolStripMenuItem.Text = "DoS SYN";
            this.doSSYNToolStripMenuItem.Click += new System.EventHandler(this.doSSYNToolStripMenuItem_Click);
            // 
            // doSByURIIDToolStripMenuItem
            // 
            this.doSByURIIDToolStripMenuItem.Name = "doSByURIIDToolStripMenuItem";
            this.doSByURIIDToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doSByURIIDToolStripMenuItem.Text = "DoS by URI ID";
            this.doSByURIIDToolStripMenuItem.Click += new System.EventHandler(this.doSByURIIDToolStripMenuItem_Click);
            // 
            // doSUDPToolStripMenuItem
            // 
            this.doSUDPToolStripMenuItem.Name = "doSUDPToolStripMenuItem";
            this.doSUDPToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doSUDPToolStripMenuItem.Text = "DoS UDP";
            this.doSUDPToolStripMenuItem.Click += new System.EventHandler(this.doSUDPToolStripMenuItem_Click);
            // 
            // doSByHTTPReqToolStripMenuItem
            // 
            this.doSByHTTPReqToolStripMenuItem.Name = "doSByHTTPReqToolStripMenuItem";
            this.doSByHTTPReqToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doSByHTTPReqToolStripMenuItem.Text = "DoS by HTTP Req";
            this.doSByHTTPReqToolStripMenuItem.Click += new System.EventHandler(this.doSByHTTPReqToolStripMenuItem_Click);
            // 
            // webSpoofingToolStripMenuItem
            // 
            this.webSpoofingToolStripMenuItem.Name = "webSpoofingToolStripMenuItem";
            this.webSpoofingToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.webSpoofingToolStripMenuItem.Text = "WebSpoofing";
            this.webSpoofingToolStripMenuItem.Click += new System.EventHandler(this.webSpoofingToolStripMenuItem_Click);
            // 
            // emailSpoofingToolStripMenuItem
            // 
            this.emailSpoofingToolStripMenuItem.Name = "emailSpoofingToolStripMenuItem";
            this.emailSpoofingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.emailSpoofingToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.emailSpoofingToolStripMenuItem.Text = "Email Spoofing";
            this.emailSpoofingToolStripMenuItem.Click += new System.EventHandler(this.emailSpoofingToolStripMenuItem_Click_1);
            // 
            // twolimitsbox
            // 
            this.twolimitsbox.Location = new System.Drawing.Point(572, 31);
            this.twolimitsbox.MaxLength = 30000;
            this.twolimitsbox.Name = "twolimitsbox";
            this.twolimitsbox.Size = new System.Drawing.Size(100, 22);
            this.twolimitsbox.TabIndex = 3;
            // 
            // onelimitbox
            // 
            this.onelimitbox.Location = new System.Drawing.Point(466, 31);
            this.onelimitbox.Name = "onelimitbox";
            this.onelimitbox.Size = new System.Drawing.Size(100, 22);
            this.onelimitbox.TabIndex = 4;
            // 
            // onelimitLbl
            // 
            this.onelimitLbl.AutoSize = true;
            this.onelimitLbl.Location = new System.Drawing.Point(388, 31);
            this.onelimitLbl.Name = "onelimitLbl";
            this.onelimitLbl.Size = new System.Drawing.Size(72, 17);
            this.onelimitLbl.TabIndex = 5;
            this.onelimitLbl.Text = "One Limit:";
            // 
            // twolimitsLbl
            // 
            this.twolimitsLbl.AutoSize = true;
            this.twolimitsLbl.Location = new System.Drawing.Point(488, 31);
            this.twolimitsLbl.Name = "twolimitsLbl";
            this.twolimitsLbl.Size = new System.Drawing.Size(78, 17);
            this.twolimitsLbl.TabIndex = 6;
            this.twolimitsLbl.Text = "Two Limits:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LinktxtBox
            // 
            this.LinktxtBox.Location = new System.Drawing.Point(100, 31);
            this.LinktxtBox.Name = "LinktxtBox";
            this.LinktxtBox.Size = new System.Drawing.Size(273, 22);
            this.LinktxtBox.TabIndex = 7;
            // 
            // Linklbl
            // 
            this.Linklbl.AutoSize = true;
            this.Linklbl.Location = new System.Drawing.Point(56, 34);
            this.Linklbl.Name = "Linklbl";
            this.Linklbl.Size = new System.Drawing.Size(38, 17);
            this.Linklbl.TabIndex = 8;
            this.Linklbl.Text = "Link:";
            // 
            // URLTargettxtbox
            // 
            this.URLTargettxtbox.Location = new System.Drawing.Point(379, 29);
            this.URLTargettxtbox.Name = "URLTargettxtbox";
            this.URLTargettxtbox.Size = new System.Drawing.Size(254, 22);
            this.URLTargettxtbox.TabIndex = 9;
            // 
            // targetlbl
            // 
            this.targetlbl.AutoSize = true;
            this.targetlbl.Location = new System.Drawing.Point(280, 34);
            this.targetlbl.Name = "targetlbl";
            this.targetlbl.Size = new System.Drawing.Size(93, 17);
            this.targetlbl.TabIndex = 10;
            this.targetlbl.Text = "Targets URL:";
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(327, 32);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(24, 17);
            this.IPlbl.TabIndex = 11;
            this.IPlbl.Text = "IP:";
            // 
            // iptxtbox
            // 
            this.iptxtbox.Location = new System.Drawing.Point(347, 34);
            this.iptxtbox.Name = "iptxtbox";
            this.iptxtbox.Size = new System.Drawing.Size(100, 22);
            this.iptxtbox.TabIndex = 12;
            // 
            // portlbl
            // 
            this.portlbl.AutoSize = true;
            this.portlbl.Location = new System.Drawing.Point(453, 34);
            this.portlbl.Name = "portlbl";
            this.portlbl.Size = new System.Drawing.Size(38, 17);
            this.portlbl.TabIndex = 13;
            this.portlbl.Text = "Port:";
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(497, 34);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(100, 22);
            this.porttextbox.TabIndex = 14;
            // 
            // pathfilelbl
            // 
            this.pathfilelbl.AutoSize = true;
            this.pathfilelbl.Location = new System.Drawing.Point(56, 37);
            this.pathfilelbl.Name = "pathfilelbl";
            this.pathfilelbl.Size = new System.Drawing.Size(67, 17);
            this.pathfilelbl.TabIndex = 15;
            this.pathfilelbl.Text = "Path File:";
            // 
            // pathfiletxtbox
            // 
            this.pathfiletxtbox.Location = new System.Drawing.Point(129, 34);
            this.pathfiletxtbox.Name = "pathfiletxtbox";
            this.pathfiletxtbox.Size = new System.Drawing.Size(192, 22);
            this.pathfiletxtbox.TabIndex = 16;
            // 
            // URLtxtbox2
            // 
            this.URLtxtbox2.Location = new System.Drawing.Point(456, 31);
            this.URLtxtbox2.Name = "URLtxtbox2";
            this.URLtxtbox2.Size = new System.Drawing.Size(216, 22);
            this.URLtxtbox2.TabIndex = 17;
            // 
            // URLtrgtlbl
            // 
            this.URLtrgtlbl.AutoSize = true;
            this.URLtrgtlbl.Location = new System.Drawing.Point(364, 34);
            this.URLtrgtlbl.Name = "URLtrgtlbl";
            this.URLtrgtlbl.Size = new System.Drawing.Size(86, 17);
            this.URLtrgtlbl.TabIndex = 18;
            this.URLtrgtlbl.Text = "URLTarget: ";
            // 
            // IPSYNATTlbl
            // 
            this.IPSYNATTlbl.AutoSize = true;
            this.IPSYNATTlbl.Location = new System.Drawing.Point(227, 39);
            this.IPSYNATTlbl.Name = "IPSYNATTlbl";
            this.IPSYNATTlbl.Size = new System.Drawing.Size(24, 17);
            this.IPSYNATTlbl.TabIndex = 19;
            this.IPSYNATTlbl.Text = "IP:";
            // 
            // IPSYNATTtxtbox
            // 
            this.IPSYNATTtxtbox.Location = new System.Drawing.Point(257, 39);
            this.IPSYNATTtxtbox.Name = "IPSYNATTtxtbox";
            this.IPSYNATTtxtbox.Size = new System.Drawing.Size(147, 22);
            this.IPSYNATTtxtbox.TabIndex = 20;
            // 
            // PORTSYNATTlbl
            // 
            this.PORTSYNATTlbl.AutoSize = true;
            this.PORTSYNATTlbl.Location = new System.Drawing.Point(423, 39);
            this.PORTSYNATTlbl.Name = "PORTSYNATTlbl";
            this.PORTSYNATTlbl.Size = new System.Drawing.Size(38, 17);
            this.PORTSYNATTlbl.TabIndex = 21;
            this.PORTSYNATTlbl.Text = "Port:";
            // 
            // PORTSYNATTtxtbox
            // 
            this.PORTSYNATTtxtbox.Location = new System.Drawing.Point(497, 32);
            this.PORTSYNATTtxtbox.Name = "PORTSYNATTtxtbox";
            this.PORTSYNATTtxtbox.Size = new System.Drawing.Size(100, 22);
            this.PORTSYNATTtxtbox.TabIndex = 22;
            // 
            // lbllinkcp
            // 
            this.lbllinkcp.AutoSize = true;
            this.lbllinkcp.Location = new System.Drawing.Point(280, 42);
            this.lbllinkcp.Name = "lbllinkcp";
            this.lbllinkcp.Size = new System.Drawing.Size(38, 17);
            this.lbllinkcp.TabIndex = 23;
            this.lbllinkcp.Text = "Link:";
            // 
            // txtbxcplink
            // 
            this.txtbxcplink.Location = new System.Drawing.Point(426, 39);
            this.txtbxcplink.Name = "txtbxcplink";
            this.txtbxcplink.Size = new System.Drawing.Size(246, 22);
            this.txtbxcplink.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.txtbxcplink);
            this.Controls.Add(this.lbllinkcp);
            this.Controls.Add(this.PORTSYNATTtxtbox);
            this.Controls.Add(this.PORTSYNATTlbl);
            this.Controls.Add(this.IPSYNATTtxtbox);
            this.Controls.Add(this.IPSYNATTlbl);
            this.Controls.Add(this.URLtrgtlbl);
            this.Controls.Add(this.URLtxtbox2);
            this.Controls.Add(this.pathfiletxtbox);
            this.Controls.Add(this.pathfilelbl);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.portlbl);
            this.Controls.Add(this.iptxtbox);
            this.Controls.Add(this.IPlbl);
            this.Controls.Add(this.targetlbl);
            this.Controls.Add(this.URLTargettxtbox);
            this.Controls.Add(this.Linklbl);
            this.Controls.Add(this.LinktxtBox);
            this.Controls.Add(this.twolimitsLbl);
            this.Controls.Add(this.onelimitLbl);
            this.Controls.Add(this.onelimitbox);
            this.Controls.Add(this.twolimitsbox);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.Runbtn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM4P ⓒ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Runbtn;
        private System.Windows.Forms.TextBox dane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnWindowWithOnePassLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnWindowWithTwoPassLimitsToolStripMenuItem;
        private System.Windows.Forms.TextBox twolimitsbox;
        private System.Windows.Forms.TextBox onelimitbox;
        private System.Windows.Forms.Label onelimitLbl;
        private System.Windows.Forms.Label twolimitsLbl;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setcolorofbackground;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundTwoLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundRunButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersTwoLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorDataWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorNameOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorNameTwoLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColoTextRunButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takingDataFromWebSiteToolStripMenuItem;
        private System.Windows.Forms.TextBox LinktxtBox;
        private System.Windows.Forms.Label Linklbl;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1251ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1252ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1253ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1254ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1255ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows1257ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doSSYNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doSByURIIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doSUDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doSByHTTPReqToolStripMenuItem;
        private System.Windows.Forms.TextBox URLTargettxtbox;
        private System.Windows.Forms.Label targetlbl;
        private System.Windows.Forms.Label IPlbl;
        private System.Windows.Forms.TextBox iptxtbox;
        private System.Windows.Forms.Label portlbl;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.Label pathfilelbl;
        private System.Windows.Forms.TextBox pathfiletxtbox;
        private System.Windows.Forms.TextBox URLtxtbox2;
        private System.Windows.Forms.Label URLtrgtlbl;
        private System.Windows.Forms.Label IPSYNATTlbl;
        private System.Windows.Forms.TextBox IPSYNATTtxtbox;
        private System.Windows.Forms.Label PORTSYNATTlbl;
        private System.Windows.Forms.TextBox PORTSYNATTtxtbox;
        private System.Windows.Forms.ToolStripMenuItem doSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webSpoofingToolStripMenuItem;
        private System.Windows.Forms.Label lbllinkcp;
        private System.Windows.Forms.TextBox txtbxcplink;
        private System.Windows.Forms.ToolStripMenuItem emailSpoofingToolStripMenuItem;
    }
}

