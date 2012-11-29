﻿namespace ZusiTCPDemoApp
{
    partial class CMainWindow
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
                MyTCPConnection.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.lblSifa = new System.Windows.Forms.Label();
            this.lblbarbz = new System.Windows.Forms.Label();
            this.lblBzdruck = new System.Windows.Forms.Label();
            this.lblbarhll = new System.Windows.Forms.Label();
            this.lblHlldruck = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.tabEinstellungen = new System.Windows.Forms.TabControl();
            this.tabAnzeigen = new System.Windows.Forms.TabPage();
            this.pnlBremsen = new System.Windows.Forms.Panel();
            this.cbBremsen = new System.Windows.Forms.CheckBox();
            this.cbDruckhll = new System.Windows.Forms.CheckBox();
            this.cbBrh = new System.Windows.Forms.CheckBox();
            this.cbDruckbz = new System.Windows.Forms.CheckBox();
            this.pnlGrunddaten = new System.Windows.Forms.Panel();
            this.cbFahrstufenschalter = new System.Windows.Forms.CheckBox();
            this.cbGrunddaten = new System.Windows.Forms.CheckBox();
            this.cbStreckenmeter = new System.Windows.Forms.CheckBox();
            this.cbGeschwindigkeit = new System.Windows.Forms.CheckBox();
            this.cbFahrstufe = new System.Windows.Forms.CheckBox();
            this.cbLmsifa = new System.Windows.Forms.CheckBox();
            this.cbLmtueren = new System.Windows.Forms.CheckBox();
            this.cbUhrzeit = new System.Windows.Forms.CheckBox();
            this.cbLmschleudern = new System.Windows.Forms.CheckBox();
            this.tabDarstellung = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDarstMeter = new System.Windows.Forms.RadioButton();
            this.rbDarstKm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.cbFokuszurueck = new System.Windows.Forms.CheckBox();
            this.grpVerbindung = new System.Windows.Forms.GroupBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDebugpanel = new System.Windows.Forms.Button();
            this.lblFlag = new System.Windows.Forms.Label();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.lblDebugtuerbool = new System.Windows.Forms.Label();
            this.lblDebugtueren = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebugSchleudern = new System.Windows.Forms.Label();
            this.lblDebugBremsen = new System.Windows.Forms.Label();
            this.lblDebugScharf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVerz = new System.Windows.Forms.TextBox();
            this.btnFlag = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.timerFlag = new System.Windows.Forms.Timer(this.components);
            this.btnNacht = new System.Windows.Forms.Button();
            this.lblm = new System.Windows.Forms.Label();
            this.lblBrh = new System.Windows.Forms.Label();
            this.lblbremsh = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.lblkmh = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.pnlData1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbltuer = new System.Windows.Forms.Label();
            this.lblfahrst = new System.Windows.Forms.Label();
            this.lblFahrstufe = new System.Windows.Forms.Label();
            this.lblTueren = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlData2 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVerbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbTopmost = new System.Windows.Forms.CheckBox();
            this.numSifagroesse = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            this.tabEinstellungen.SuspendLayout();
            this.tabAnzeigen.SuspendLayout();
            this.pnlBremsen.SuspendLayout();
            this.pnlGrunddaten.SuspendLayout();
            this.tabDarstellung.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.grpVerbindung.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlData1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlData2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSifagroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifa
            // 
            this.lblSifa.BackColor = System.Drawing.Color.DarkGray;
            this.lblSifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifa.Location = new System.Drawing.Point(6, 7);
            this.lblSifa.Name = "lblSifa";
            this.lblSifa.Size = new System.Drawing.Size(114, 51);
            this.lblSifa.TabIndex = 0;
            this.lblSifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbarbz
            // 
            this.lblbarbz.AutoSize = true;
            this.lblbarbz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblbarbz.Location = new System.Drawing.Point(34, 26);
            this.lblbarbz.Name = "lblbarbz";
            this.lblbarbz.Size = new System.Drawing.Size(37, 13);
            this.lblbarbz.TabIndex = 11;
            this.lblbarbz.Text = "bar Bz";
            // 
            // lblBzdruck
            // 
            this.lblBzdruck.AutoSize = true;
            this.lblBzdruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBzdruck.Location = new System.Drawing.Point(3, 26);
            this.lblBzdruck.Name = "lblBzdruck";
            this.lblBzdruck.Size = new System.Drawing.Size(25, 13);
            this.lblBzdruck.TabIndex = 10;
            this.lblBzdruck.Text = "8,8";
            // 
            // lblbarhll
            // 
            this.lblbarhll.AutoSize = true;
            this.lblbarhll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblbarhll.Location = new System.Drawing.Point(34, 13);
            this.lblbarhll.Name = "lblbarhll";
            this.lblbarhll.Size = new System.Drawing.Size(37, 13);
            this.lblbarhll.TabIndex = 9;
            this.lblbarhll.Text = "bar Hll";
            // 
            // lblHlldruck
            // 
            this.lblHlldruck.AutoSize = true;
            this.lblHlldruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHlldruck.Location = new System.Drawing.Point(3, 13);
            this.lblHlldruck.Name = "lblHlldruck";
            this.lblHlldruck.Size = new System.Drawing.Size(25, 13);
            this.lblHlldruck.TabIndex = 8;
            this.lblHlldruck.Text = "8,8";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(3, 247);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(94, 26);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.Controls.Add(this.tabEinstellungen);
            this.pnlSettings.Location = new System.Drawing.Point(3, 1);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(215, 231);
            this.pnlSettings.TabIndex = 10;
            // 
            // tabEinstellungen
            // 
            this.tabEinstellungen.Controls.Add(this.tabAnzeigen);
            this.tabEinstellungen.Controls.Add(this.tabDarstellung);
            this.tabEinstellungen.Controls.Add(this.tabSystem);
            this.tabEinstellungen.Location = new System.Drawing.Point(3, 2);
            this.tabEinstellungen.Name = "tabEinstellungen";
            this.tabEinstellungen.SelectedIndex = 0;
            this.tabEinstellungen.Size = new System.Drawing.Size(209, 226);
            this.tabEinstellungen.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabEinstellungen.TabIndex = 0;
            // 
            // tabAnzeigen
            // 
            this.tabAnzeigen.BackColor = System.Drawing.SystemColors.Control;
            this.tabAnzeigen.Controls.Add(this.pnlBremsen);
            this.tabAnzeigen.Controls.Add(this.pnlGrunddaten);
            this.tabAnzeigen.Location = new System.Drawing.Point(4, 22);
            this.tabAnzeigen.Name = "tabAnzeigen";
            this.tabAnzeigen.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnzeigen.Size = new System.Drawing.Size(201, 200);
            this.tabAnzeigen.TabIndex = 0;
            this.tabAnzeigen.Text = "Anzeigen";
            // 
            // pnlBremsen
            // 
            this.pnlBremsen.Controls.Add(this.cbBremsen);
            this.pnlBremsen.Controls.Add(this.cbDruckhll);
            this.pnlBremsen.Controls.Add(this.cbBrh);
            this.pnlBremsen.Controls.Add(this.cbDruckbz);
            this.pnlBremsen.Location = new System.Drawing.Point(3, 123);
            this.pnlBremsen.Name = "pnlBremsen";
            this.pnlBremsen.Size = new System.Drawing.Size(183, 67);
            this.pnlBremsen.TabIndex = 19;
            // 
            // cbBremsen
            // 
            this.cbBremsen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBremsen.AutoSize = true;
            this.cbBremsen.Checked = true;
            this.cbBremsen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBremsen.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbBremsen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbBremsen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBremsen.Location = new System.Drawing.Point(3, 3);
            this.cbBremsen.Name = "cbBremsen";
            this.cbBremsen.Size = new System.Drawing.Size(58, 23);
            this.cbBremsen.TabIndex = 9;
            this.cbBremsen.Text = "Bremsen";
            this.cbBremsen.UseVisualStyleBackColor = true;
            this.cbBremsen.CheckedChanged += new System.EventHandler(this.cbBremsen_CheckedChanged);
            // 
            // cbDruckhll
            // 
            this.cbDruckhll.AutoSize = true;
            this.cbDruckhll.Checked = true;
            this.cbDruckhll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDruckhll.Location = new System.Drawing.Point(113, 30);
            this.cbDruckhll.Name = "cbDruckhll";
            this.cbDruckhll.Size = new System.Drawing.Size(70, 17);
            this.cbDruckhll.TabIndex = 2;
            this.cbDruckhll.Text = "Druck Hll";
            this.cbDruckhll.UseVisualStyleBackColor = true;
            this.cbDruckhll.CheckedChanged += new System.EventHandler(this.cbDruckhll_CheckedChanged);
            // 
            // cbBrh
            // 
            this.cbBrh.AutoSize = true;
            this.cbBrh.Checked = true;
            this.cbBrh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBrh.Location = new System.Drawing.Point(3, 30);
            this.cbBrh.Name = "cbBrh";
            this.cbBrh.Size = new System.Drawing.Size(107, 17);
            this.cbBrh.TabIndex = 4;
            this.cbBrh.Text = "Bremshundertstel";
            this.cbBrh.UseVisualStyleBackColor = true;
            this.cbBrh.CheckedChanged += new System.EventHandler(this.cbBrh_CheckedChanged);
            // 
            // cbDruckbz
            // 
            this.cbDruckbz.AutoSize = true;
            this.cbDruckbz.Checked = true;
            this.cbDruckbz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDruckbz.Location = new System.Drawing.Point(3, 47);
            this.cbDruckbz.Name = "cbDruckbz";
            this.cbDruckbz.Size = new System.Drawing.Size(122, 17);
            this.cbDruckbz.TabIndex = 3;
            this.cbDruckbz.Text = "Druck Bremszylinder";
            this.cbDruckbz.UseVisualStyleBackColor = true;
            this.cbDruckbz.CheckedChanged += new System.EventHandler(this.cbDruckbz_CheckedChanged);
            // 
            // pnlGrunddaten
            // 
            this.pnlGrunddaten.Controls.Add(this.cbFahrstufenschalter);
            this.pnlGrunddaten.Controls.Add(this.cbGrunddaten);
            this.pnlGrunddaten.Controls.Add(this.cbStreckenmeter);
            this.pnlGrunddaten.Controls.Add(this.cbGeschwindigkeit);
            this.pnlGrunddaten.Controls.Add(this.cbFahrstufe);
            this.pnlGrunddaten.Controls.Add(this.cbLmsifa);
            this.pnlGrunddaten.Controls.Add(this.cbLmtueren);
            this.pnlGrunddaten.Controls.Add(this.cbUhrzeit);
            this.pnlGrunddaten.Controls.Add(this.cbLmschleudern);
            this.pnlGrunddaten.Location = new System.Drawing.Point(3, 3);
            this.pnlGrunddaten.Name = "pnlGrunddaten";
            this.pnlGrunddaten.Size = new System.Drawing.Size(183, 116);
            this.pnlGrunddaten.TabIndex = 19;
            // 
            // cbFahrstufenschalter
            // 
            this.cbFahrstufenschalter.AutoSize = true;
            this.cbFahrstufenschalter.Location = new System.Drawing.Point(3, 81);
            this.cbFahrstufenschalter.Name = "cbFahrstufenschalter";
            this.cbFahrstufenschalter.Size = new System.Drawing.Size(84, 17);
            this.cbFahrstufenschalter.TabIndex = 9;
            this.cbFahrstufenschalter.Text = "Fahrschalter";
            this.cbFahrstufenschalter.UseVisualStyleBackColor = true;
            this.cbFahrstufenschalter.CheckedChanged += new System.EventHandler(this.cbFahrstufenschalter_CheckedChanged);
            // 
            // cbGrunddaten
            // 
            this.cbGrunddaten.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGrunddaten.AutoSize = true;
            this.cbGrunddaten.Checked = true;
            this.cbGrunddaten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrunddaten.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbGrunddaten.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbGrunddaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrunddaten.Location = new System.Drawing.Point(3, 3);
            this.cbGrunddaten.Name = "cbGrunddaten";
            this.cbGrunddaten.Size = new System.Drawing.Size(73, 23);
            this.cbGrunddaten.TabIndex = 8;
            this.cbGrunddaten.Text = "Grunddaten";
            this.cbGrunddaten.UseVisualStyleBackColor = true;
            this.cbGrunddaten.CheckedChanged += new System.EventHandler(this.cbGrunddaten_CheckedChanged);
            // 
            // cbStreckenmeter
            // 
            this.cbStreckenmeter.AutoSize = true;
            this.cbStreckenmeter.Checked = true;
            this.cbStreckenmeter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStreckenmeter.Location = new System.Drawing.Point(3, 49);
            this.cbStreckenmeter.Name = "cbStreckenmeter";
            this.cbStreckenmeter.Size = new System.Drawing.Size(95, 17);
            this.cbStreckenmeter.TabIndex = 1;
            this.cbStreckenmeter.Text = "Streckenmeter";
            this.cbStreckenmeter.UseVisualStyleBackColor = true;
            this.cbStreckenmeter.CheckedChanged += new System.EventHandler(this.cbStreckenmeter_CheckedChanged);
            // 
            // cbGeschwindigkeit
            // 
            this.cbGeschwindigkeit.AutoSize = true;
            this.cbGeschwindigkeit.Checked = true;
            this.cbGeschwindigkeit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGeschwindigkeit.Location = new System.Drawing.Point(3, 32);
            this.cbGeschwindigkeit.Name = "cbGeschwindigkeit";
            this.cbGeschwindigkeit.Size = new System.Drawing.Size(104, 17);
            this.cbGeschwindigkeit.TabIndex = 0;
            this.cbGeschwindigkeit.Text = "Geschwindigkeit";
            this.cbGeschwindigkeit.UseVisualStyleBackColor = true;
            this.cbGeschwindigkeit.CheckedChanged += new System.EventHandler(this.cbGeschwindigkeit_CheckedChanged);
            // 
            // cbFahrstufe
            // 
            this.cbFahrstufe.AutoSize = true;
            this.cbFahrstufe.Checked = true;
            this.cbFahrstufe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFahrstufe.Location = new System.Drawing.Point(3, 65);
            this.cbFahrstufe.Name = "cbFahrstufe";
            this.cbFahrstufe.Size = new System.Drawing.Size(70, 17);
            this.cbFahrstufe.TabIndex = 7;
            this.cbFahrstufe.Text = "Fahrstufe";
            this.cbFahrstufe.UseVisualStyleBackColor = true;
            this.cbFahrstufe.CheckedChanged += new System.EventHandler(this.cbFahrstufe_CheckedChanged);
            // 
            // cbLmsifa
            // 
            this.cbLmsifa.AutoSize = true;
            this.cbLmsifa.Checked = true;
            this.cbLmsifa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLmsifa.Location = new System.Drawing.Point(113, 32);
            this.cbLmsifa.Name = "cbLmsifa";
            this.cbLmsifa.Size = new System.Drawing.Size(44, 17);
            this.cbLmsifa.TabIndex = 2;
            this.cbLmsifa.Text = "Sifa";
            this.cbLmsifa.UseVisualStyleBackColor = true;
            this.cbLmsifa.CheckedChanged += new System.EventHandler(this.cbLmsifa_CheckedChanged);
            // 
            // cbLmtueren
            // 
            this.cbLmtueren.AutoSize = true;
            this.cbLmtueren.Checked = true;
            this.cbLmtueren.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLmtueren.Location = new System.Drawing.Point(113, 49);
            this.cbLmtueren.Name = "cbLmtueren";
            this.cbLmtueren.Size = new System.Drawing.Size(54, 17);
            this.cbLmtueren.TabIndex = 3;
            this.cbLmtueren.Text = "Türen";
            this.cbLmtueren.UseVisualStyleBackColor = true;
            this.cbLmtueren.CheckedChanged += new System.EventHandler(this.cbLmtueren_CheckedChanged);
            // 
            // cbUhrzeit
            // 
            this.cbUhrzeit.AutoSize = true;
            this.cbUhrzeit.Enabled = false;
            this.cbUhrzeit.Location = new System.Drawing.Point(113, 65);
            this.cbUhrzeit.Name = "cbUhrzeit";
            this.cbUhrzeit.Size = new System.Drawing.Size(59, 17);
            this.cbUhrzeit.TabIndex = 6;
            this.cbUhrzeit.Text = "Uhrzeit";
            this.cbUhrzeit.UseVisualStyleBackColor = true;
            // 
            // cbLmschleudern
            // 
            this.cbLmschleudern.AutoSize = true;
            this.cbLmschleudern.Checked = true;
            this.cbLmschleudern.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLmschleudern.Location = new System.Drawing.Point(3, 99);
            this.cbLmschleudern.Name = "cbLmschleudern";
            this.cbLmschleudern.Size = new System.Drawing.Size(142, 17);
            this.cbLmschleudern.TabIndex = 4;
            this.cbLmschleudern.Text = "LM Schleudern / Gleiten";
            this.cbLmschleudern.UseVisualStyleBackColor = true;
            this.cbLmschleudern.CheckedChanged += new System.EventHandler(this.cbLmschleudern_CheckedChanged);
            // 
            // tabDarstellung
            // 
            this.tabDarstellung.BackColor = System.Drawing.SystemColors.Control;
            this.tabDarstellung.Controls.Add(this.label3);
            this.tabDarstellung.Controls.Add(this.numSifagroesse);
            this.tabDarstellung.Controls.Add(this.panel1);
            this.tabDarstellung.Controls.Add(this.label2);
            this.tabDarstellung.Location = new System.Drawing.Point(4, 22);
            this.tabDarstellung.Name = "tabDarstellung";
            this.tabDarstellung.Padding = new System.Windows.Forms.Padding(3);
            this.tabDarstellung.Size = new System.Drawing.Size(201, 200);
            this.tabDarstellung.TabIndex = 1;
            this.tabDarstellung.Text = "Darstellung";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDarstMeter);
            this.panel1.Controls.Add(this.rbDarstKm);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 23);
            this.panel1.TabIndex = 3;
            // 
            // rbDarstMeter
            // 
            this.rbDarstMeter.AutoSize = true;
            this.rbDarstMeter.Location = new System.Drawing.Point(3, 0);
            this.rbDarstMeter.Name = "rbDarstMeter";
            this.rbDarstMeter.Size = new System.Drawing.Size(52, 17);
            this.rbDarstMeter.TabIndex = 1;
            this.rbDarstMeter.Text = "Meter";
            this.rbDarstMeter.UseVisualStyleBackColor = true;
            this.rbDarstMeter.CheckedChanged += new System.EventHandler(this.rbDarstMeter_CheckedChanged);
            // 
            // rbDarstKm
            // 
            this.rbDarstKm.AutoSize = true;
            this.rbDarstKm.Checked = true;
            this.rbDarstKm.Location = new System.Drawing.Point(61, 0);
            this.rbDarstKm.Name = "rbDarstKm";
            this.rbDarstKm.Size = new System.Drawing.Size(68, 17);
            this.rbDarstKm.TabIndex = 2;
            this.rbDarstKm.TabStop = true;
            this.rbDarstKm.Text = "Kilometer";
            this.rbDarstKm.UseVisualStyleBackColor = true;
            this.rbDarstKm.CheckedChanged += new System.EventHandler(this.rbDarstKm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Streckenmeter";
            // 
            // tabSystem
            // 
            this.tabSystem.BackColor = System.Drawing.SystemColors.Control;
            this.tabSystem.Controls.Add(this.cbTopmost);
            this.tabSystem.Controls.Add(this.cbFokuszurueck);
            this.tabSystem.Controls.Add(this.grpVerbindung);
            this.tabSystem.Controls.Add(this.btnDebugpanel);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(201, 200);
            this.tabSystem.TabIndex = 2;
            this.tabSystem.Text = "System";
            // 
            // cbFokuszurueck
            // 
            this.cbFokuszurueck.AutoSize = true;
            this.cbFokuszurueck.Location = new System.Drawing.Point(10, 148);
            this.cbFokuszurueck.Name = "cbFokuszurueck";
            this.cbFokuszurueck.Size = new System.Drawing.Size(181, 17);
            this.cbFokuszurueck.TabIndex = 14;
            this.cbFokuszurueck.Text = "Fokus nach Klick zurück an Zusi";
            this.cbFokuszurueck.UseVisualStyleBackColor = true;
            // 
            // grpVerbindung
            // 
            this.grpVerbindung.Controls.Add(this.tbServer);
            this.grpVerbindung.Controls.Add(this.tbPort);
            this.grpVerbindung.Controls.Add(this.btnConnect);
            this.grpVerbindung.Location = new System.Drawing.Point(3, 4);
            this.grpVerbindung.Name = "grpVerbindung";
            this.grpVerbindung.Size = new System.Drawing.Size(121, 114);
            this.grpVerbindung.TabIndex = 12;
            this.grpVerbindung.TabStop = false;
            this.grpVerbindung.Text = "Verbindung";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(7, 26);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(74, 20);
            this.tbServer.TabIndex = 13;
            this.tbServer.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(7, 52);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(74, 20);
            this.tbPort.TabIndex = 12;
            this.tbPort.Text = "1435";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 78);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDebugpanel
            // 
            this.btnDebugpanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnDebugpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugpanel.Location = new System.Drawing.Point(130, 89);
            this.btnDebugpanel.Name = "btnDebugpanel";
            this.btnDebugpanel.Size = new System.Drawing.Size(58, 29);
            this.btnDebugpanel.TabIndex = 13;
            this.btnDebugpanel.Text = "DEBUG";
            this.btnDebugpanel.UseVisualStyleBackColor = true;
            this.btnDebugpanel.Click += new System.EventHandler(this.btnDebugpanel_Click);
            // 
            // lblFlag
            // 
            this.lblFlag.BackColor = System.Drawing.Color.Orange;
            this.lblFlag.Location = new System.Drawing.Point(6, 62);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(114, 19);
            this.lblFlag.TabIndex = 11;
            this.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlag.Visible = false;
            // 
            // pnlDebug
            // 
            this.pnlDebug.AutoSize = true;
            this.pnlDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDebug.Controls.Add(this.grpDebug);
            this.pnlDebug.Location = new System.Drawing.Point(223, 3);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(138, 248);
            this.pnlDebug.TabIndex = 12;
            this.pnlDebug.Visible = false;
            // 
            // grpDebug
            // 
            this.grpDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDebug.Controls.Add(this.lblDebugtuerbool);
            this.grpDebug.Controls.Add(this.lblDebugtueren);
            this.grpDebug.Controls.Add(this.label1);
            this.grpDebug.Controls.Add(this.lblDebugSchleudern);
            this.grpDebug.Controls.Add(this.lblDebugBremsen);
            this.grpDebug.Controls.Add(this.lblDebugScharf);
            this.grpDebug.Controls.Add(this.label13);
            this.grpDebug.Controls.Add(this.label12);
            this.grpDebug.Controls.Add(this.tbVerz);
            this.grpDebug.Controls.Add(this.btnFlag);
            this.grpDebug.Location = new System.Drawing.Point(3, 3);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(132, 242);
            this.grpDebug.TabIndex = 12;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug";
            // 
            // lblDebugtuerbool
            // 
            this.lblDebugtuerbool.AutoSize = true;
            this.lblDebugtuerbool.Location = new System.Drawing.Point(50, 120);
            this.lblDebugtuerbool.Name = "lblDebugtuerbool";
            this.lblDebugtuerbool.Size = new System.Drawing.Size(37, 13);
            this.lblDebugtuerbool.TabIndex = 29;
            this.lblDebugtuerbool.Text = "(türen)";
            // 
            // lblDebugtueren
            // 
            this.lblDebugtueren.AutoSize = true;
            this.lblDebugtueren.Location = new System.Drawing.Point(48, 107);
            this.lblDebugtueren.Name = "lblDebugtueren";
            this.lblDebugtueren.Size = new System.Drawing.Size(37, 13);
            this.lblDebugtueren.TabIndex = 28;
            this.lblDebugtueren.Text = "(türen)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Türen";
            // 
            // lblDebugSchleudern
            // 
            this.lblDebugSchleudern.AutoSize = true;
            this.lblDebugSchleudern.Location = new System.Drawing.Point(6, 210);
            this.lblDebugSchleudern.Name = "lblDebugSchleudern";
            this.lblDebugSchleudern.Size = new System.Drawing.Size(65, 13);
            this.lblDebugSchleudern.TabIndex = 26;
            this.lblDebugSchleudern.Text = "(schleudern)";
            // 
            // lblDebugBremsen
            // 
            this.lblDebugBremsen.AutoSize = true;
            this.lblDebugBremsen.Location = new System.Drawing.Point(6, 196);
            this.lblDebugBremsen.Name = "lblDebugBremsen";
            this.lblDebugBremsen.Size = new System.Drawing.Size(53, 13);
            this.lblDebugBremsen.TabIndex = 22;
            this.lblDebugBremsen.Text = "(bremsen)";
            // 
            // lblDebugScharf
            // 
            this.lblDebugScharf.AutoSize = true;
            this.lblDebugScharf.Location = new System.Drawing.Point(6, 181);
            this.lblDebugScharf.Name = "lblDebugScharf";
            this.lblDebugScharf.Size = new System.Drawing.Size(42, 13);
            this.lblDebugScharf.TabIndex = 21;
            this.lblDebugScharf.Text = "(scharf)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "max. Verzögerung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "m/s²";
            // 
            // tbVerz
            // 
            this.tbVerz.Location = new System.Drawing.Point(6, 67);
            this.tbVerz.Name = "tbVerz";
            this.tbVerz.Size = new System.Drawing.Size(36, 20);
            this.tbVerz.TabIndex = 18;
            this.tbVerz.Text = "0,5";
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(6, 25);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(60, 23);
            this.btnFlag.TabIndex = 11;
            this.btnFlag.Text = "flag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.AutoSize = true;
            this.pnlRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRight.Controls.Add(this.pnlSettings);
            this.pnlRight.Controls.Add(this.pnlDebug);
            this.pnlRight.Location = new System.Drawing.Point(149, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(364, 254);
            this.pnlRight.TabIndex = 14;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // timerFlag
            // 
            this.timerFlag.Enabled = true;
            this.timerFlag.Interval = 1000;
            this.timerFlag.Tick += new System.EventHandler(this.timerFlag_Tick);
            // 
            // btnNacht
            // 
            this.btnNacht.Location = new System.Drawing.Point(3, 218);
            this.btnNacht.Name = "btnNacht";
            this.btnNacht.Size = new System.Drawing.Size(94, 23);
            this.btnNacht.TabIndex = 15;
            this.btnNacht.Text = "Nachtmodus";
            this.btnNacht.UseVisualStyleBackColor = true;
            this.btnNacht.Click += new System.EventHandler(this.btnNacht_Click);
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblm.Location = new System.Drawing.Point(69, 24);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(51, 13);
            this.lblm.TabIndex = 5;
            this.lblm.Text = "km";
            // 
            // lblBrh
            // 
            this.lblBrh.AutoSize = true;
            this.lblBrh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrh.Location = new System.Drawing.Point(3, 0);
            this.lblBrh.Name = "lblBrh";
            this.lblBrh.Size = new System.Drawing.Size(25, 13);
            this.lblBrh.TabIndex = 7;
            this.lblBrh.Text = "888";
            // 
            // lblbremsh
            // 
            this.lblbremsh.AutoSize = true;
            this.lblbremsh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblbremsh.Location = new System.Drawing.Point(34, 0);
            this.lblbremsh.Name = "lblbremsh";
            this.lblbremsh.Size = new System.Drawing.Size(37, 13);
            this.lblbremsh.TabIndex = 6;
            this.lblbremsh.Text = "BrH";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeter.Location = new System.Drawing.Point(3, 24);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(60, 13);
            this.lblMeter.TabIndex = 3;
            this.lblMeter.Text = "888888,88";
            // 
            // lblkmh
            // 
            this.lblkmh.AutoSize = true;
            this.lblkmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblkmh.Location = new System.Drawing.Point(69, 0);
            this.lblkmh.Name = "lblkmh";
            this.lblkmh.Size = new System.Drawing.Size(51, 24);
            this.lblkmh.TabIndex = 4;
            this.lblkmh.Text = "km/h";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(3, 0);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(60, 24);
            this.lblV.TabIndex = 1;
            this.lblV.Text = "888,8";
            // 
            // pnlData1
            // 
            this.pnlData1.AutoSize = true;
            this.pnlData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlData1.ColumnCount = 2;
            this.pnlData1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlData1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlData1.Controls.Add(this.lbltuer, 1, 3);
            this.pnlData1.Controls.Add(this.lblfahrst, 1, 2);
            this.pnlData1.Controls.Add(this.lblFahrstufe, 0, 2);
            this.pnlData1.Controls.Add(this.lblV, 0, 0);
            this.pnlData1.Controls.Add(this.lblkmh, 1, 0);
            this.pnlData1.Controls.Add(this.lblMeter, 0, 1);
            this.pnlData1.Controls.Add(this.lblm, 1, 1);
            this.pnlData1.Controls.Add(this.lblTueren, 0, 3);
            this.pnlData1.Location = new System.Drawing.Point(3, 94);
            this.pnlData1.Name = "pnlData1";
            this.pnlData1.RowCount = 4;
            this.pnlData1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlData1.Size = new System.Drawing.Size(123, 63);
            this.pnlData1.TabIndex = 16;
            // 
            // lbltuer
            // 
            this.lbltuer.AutoSize = true;
            this.lbltuer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltuer.Location = new System.Drawing.Point(69, 50);
            this.lbltuer.Name = "lbltuer";
            this.lbltuer.Size = new System.Drawing.Size(51, 13);
            this.lbltuer.TabIndex = 18;
            this.lbltuer.Text = "Türen";
            // 
            // lblfahrst
            // 
            this.lblfahrst.AutoSize = true;
            this.lblfahrst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfahrst.Location = new System.Drawing.Point(69, 37);
            this.lblfahrst.Name = "lblfahrst";
            this.lblfahrst.Size = new System.Drawing.Size(51, 13);
            this.lblfahrst.TabIndex = 7;
            this.lblfahrst.Text = "Fahrstufe";
            // 
            // lblFahrstufe
            // 
            this.lblFahrstufe.AutoSize = true;
            this.lblFahrstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFahrstufe.Location = new System.Drawing.Point(3, 37);
            this.lblFahrstufe.Name = "lblFahrstufe";
            this.lblFahrstufe.Size = new System.Drawing.Size(60, 13);
            this.lblFahrstufe.TabIndex = 6;
            this.lblFahrstufe.Text = "88";
            // 
            // lblTueren
            // 
            this.lblTueren.AutoSize = true;
            this.lblTueren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTueren.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTueren.Location = new System.Drawing.Point(3, 50);
            this.lblTueren.Name = "lblTueren";
            this.lblTueren.Size = new System.Drawing.Size(60, 13);
            this.lblTueren.TabIndex = 8;
            this.lblTueren.Text = "########";
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoSize = true;
            this.pnlLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeft.Controls.Add(this.pnlData2);
            this.pnlLeft.Controls.Add(this.pnlData1);
            this.pnlLeft.Controls.Add(this.lblFlag);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.lblSifa);
            this.pnlLeft.Controls.Add(this.btnNacht);
            this.pnlLeft.Location = new System.Drawing.Point(2, 13);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(129, 276);
            this.pnlLeft.TabIndex = 17;
            // 
            // pnlData2
            // 
            this.pnlData2.AutoSize = true;
            this.pnlData2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlData2.ColumnCount = 2;
            this.pnlData2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlData2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlData2.Controls.Add(this.lblBrh, 0, 0);
            this.pnlData2.Controls.Add(this.lblbarbz, 1, 2);
            this.pnlData2.Controls.Add(this.lblbremsh, 1, 0);
            this.pnlData2.Controls.Add(this.lblHlldruck, 0, 1);
            this.pnlData2.Controls.Add(this.lblbarhll, 1, 1);
            this.pnlData2.Controls.Add(this.lblBzdruck, 0, 2);
            this.pnlData2.Location = new System.Drawing.Point(3, 168);
            this.pnlData2.Name = "pnlData2";
            this.pnlData2.RowCount = 3;
            this.pnlData2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData2.Size = new System.Drawing.Size(74, 39);
            this.pnlData2.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVerbstatus});
            this.statusStrip1.Location = new System.Drawing.Point(2, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(129, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVerbstatus
            // 
            this.lblVerbstatus.Name = "lblVerbstatus";
            this.lblVerbstatus.Size = new System.Drawing.Size(52, 18);
            this.lblVerbstatus.Text = "getrennt";
            // 
            // cbTopmost
            // 
            this.cbTopmost.AutoSize = true;
            this.cbTopmost.Checked = true;
            this.cbTopmost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopmost.Location = new System.Drawing.Point(10, 130);
            this.cbTopmost.Name = "cbTopmost";
            this.cbTopmost.Size = new System.Drawing.Size(128, 17);
            this.cbTopmost.TabIndex = 15;
            this.cbTopmost.Text = "Immer im Vordergrund";
            this.cbTopmost.UseVisualStyleBackColor = true;
            this.cbTopmost.CheckedChanged += new System.EventHandler(this.cbTopmost_CheckedChanged);
            // 
            // numSifagroesse
            // 
            this.numSifagroesse.Location = new System.Drawing.Point(68, 53);
            this.numSifagroesse.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSifagroesse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSifagroesse.Name = "numSifagroesse";
            this.numSifagroesse.ReadOnly = true;
            this.numSifagroesse.Size = new System.Drawing.Size(29, 20);
            this.numSifagroesse.TabIndex = 4;
            this.numSifagroesse.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numSifagroesse.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSifagroesse.ValueChanged += new System.EventHandler(this.numSifagroesse_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Größe Sifa";
            // 
            // CMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CMainWindow";
            this.Text = "ZusiMeter - v0.4";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CMainWindow_Load);
            this.pnlSettings.ResumeLayout(false);
            this.tabEinstellungen.ResumeLayout(false);
            this.tabAnzeigen.ResumeLayout(false);
            this.pnlBremsen.ResumeLayout(false);
            this.pnlBremsen.PerformLayout();
            this.pnlGrunddaten.ResumeLayout(false);
            this.pnlGrunddaten.PerformLayout();
            this.tabDarstellung.ResumeLayout(false);
            this.tabDarstellung.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            this.grpVerbindung.ResumeLayout(false);
            this.grpVerbindung.PerformLayout();
            this.pnlDebug.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlData1.ResumeLayout(false);
            this.pnlData1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlData2.ResumeLayout(false);
            this.pnlData2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSifagroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifa;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpVerbindung;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.GroupBox grpDebug;
        private System.Windows.Forms.Label lblDebugBremsen;
        private System.Windows.Forms.Label lblDebugScharf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVerz;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnDebugpanel;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDebugSchleudern;
        private System.Windows.Forms.Timer timerFlag;
        private System.Windows.Forms.Button btnNacht;
        private System.Windows.Forms.Label lblbarhll;
        private System.Windows.Forms.Label lblHlldruck;
        private System.Windows.Forms.Label lblbarbz;
        private System.Windows.Forms.Label lblBzdruck;
        private System.Windows.Forms.CheckBox cbBrh;
        private System.Windows.Forms.CheckBox cbDruckbz;
        private System.Windows.Forms.CheckBox cbDruckhll;
        private System.Windows.Forms.CheckBox cbStreckenmeter;
        private System.Windows.Forms.CheckBox cbGeschwindigkeit;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lblBrh;
        private System.Windows.Forms.Label lblbremsh;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Label lblkmh;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.TableLayoutPanel pnlData1;
        private System.Windows.Forms.TabControl tabEinstellungen;
        private System.Windows.Forms.TabPage tabAnzeigen;
        private System.Windows.Forms.TabPage tabDarstellung;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.CheckBox cbLmsifa;
        private System.Windows.Forms.CheckBox cbLmschleudern;
        private System.Windows.Forms.CheckBox cbLmtueren;
        private System.Windows.Forms.CheckBox cbFahrstufe;
        private System.Windows.Forms.CheckBox cbUhrzeit;
        private System.Windows.Forms.CheckBox cbFokuszurueck;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel pnlData2;
        private System.Windows.Forms.Label lblfahrst;
        private System.Windows.Forms.Label lblFahrstufe;
        private System.Windows.Forms.CheckBox cbGrunddaten;
        private System.Windows.Forms.CheckBox cbBremsen;
        private System.Windows.Forms.Label lbltuer;
        private System.Windows.Forms.Label lblTueren;
        private System.Windows.Forms.Label lblDebugtueren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebugtuerbool;
        private System.Windows.Forms.Panel pnlBremsen;
        private System.Windows.Forms.Panel pnlGrunddaten;
        private System.Windows.Forms.CheckBox cbFahrstufenschalter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVerbstatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDarstMeter;
        private System.Windows.Forms.RadioButton rbDarstKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTopmost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSifagroesse;

    }
}

