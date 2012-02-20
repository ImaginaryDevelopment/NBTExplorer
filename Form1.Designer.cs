﻿namespace NBTExplorer
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
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMinecraftSaveFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._nodeTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._buttonOpen = new System.Windows.Forms.ToolStripButton();
            this._buttonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this._buttonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._buttonRename = new System.Windows.Forms.ToolStripButton();
            this._buttonEdit = new System.Windows.Forms.ToolStripButton();
            this._buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._buttonAddTagByte = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagShort = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagInt = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagLong = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagFloat = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagDouble = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagByteArray = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagString = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagList = new System.Windows.Forms.ToolStripButton();
            this._buttonAddTagCompound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._buttonFindNext = new System.Windows.Forms.ToolStripButton();
            this._nodeContainerContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSubTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEntityChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this._nodeContainerContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openMinecraftSaveFolderToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.folder_open_document;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.folder_open;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openFolderToolStripMenuItem.Text = "Open &Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openMinecraftSaveFolderToolStripMenuItem
            // 
            this.openMinecraftSaveFolderToolStripMenuItem.Name = "openMinecraftSaveFolderToolStripMenuItem";
            this.openMinecraftSaveFolderToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openMinecraftSaveFolderToolStripMenuItem.Text = "Open &Minecraft Save Folder";
            this.openMinecraftSaveFolderToolStripMenuItem.Click += new System.EventHandler(this.openMinecraftSaveFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.door;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.findEntityChunkToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.binocular;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.binocular__arrow;
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.information_frame;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(aboutToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this._nodeTree);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(562, 351);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(562, 376);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(547, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Please wait...";
            // 
            // _nodeTree
            // 
            this._nodeTree.AllowDrop = true;
            this._nodeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nodeTree.ImageIndex = 0;
            this._nodeTree.ImageList = this.imageList1;
            this._nodeTree.Location = new System.Drawing.Point(0, 0);
            this._nodeTree.Name = "_nodeTree";
            this._nodeTree.SelectedImageIndex = 0;
            this._nodeTree.Size = new System.Drawing.Size(562, 351);
            this._nodeTree.TabIndex = 0;
            this._nodeTree.DragDrop += new System.Windows.Forms.DragEventHandler(this._nodeTree_DragDrop);
            this._nodeTree.DragEnter += new System.Windows.Forms.DragEventHandler(_nodeTree_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document-attribute-b.png");
            this.imageList1.Images.SetKeyName(1, "document-attribute-s.png");
            this.imageList1.Images.SetKeyName(2, "document-attribute-i.png");
            this.imageList1.Images.SetKeyName(3, "document-attribute-l.png");
            this.imageList1.Images.SetKeyName(4, "document-attribute-f.png");
            this.imageList1.Images.SetKeyName(5, "document-attribute-d.png");
            this.imageList1.Images.SetKeyName(6, "edit-code.png");
            this.imageList1.Images.SetKeyName(7, "edit-small-caps.png");
            this.imageList1.Images.SetKeyName(8, "edit-list.png");
            this.imageList1.Images.SetKeyName(9, "box.png");
            this.imageList1.Images.SetKeyName(10, "folder.png");
            this.imageList1.Images.SetKeyName(11, "block.png");
            this.imageList1.Images.SetKeyName(12, "wooden-box.png");
            this.imageList1.Images.SetKeyName(13, "map.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._buttonOpen,
            this._buttonOpenFolder,
            this._buttonSave,
            this.toolStripSeparator1,
            this._buttonRename,
            this._buttonEdit,
            this._buttonDelete,
            this.toolStripSeparator2,
            this._buttonAddTagByte,
            this._buttonAddTagShort,
            this._buttonAddTagInt,
            this._buttonAddTagLong,
            this._buttonAddTagFloat,
            this._buttonAddTagDouble,
            this._buttonAddTagByteArray,
            this._buttonAddTagString,
            this._buttonAddTagList,
            this._buttonAddTagCompound,
            this.toolStripSeparator5,
            this._buttonFindNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // _buttonOpen
            // 
            this._buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("_buttonOpen.Image")));
            this._buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonOpen.Name = "_buttonOpen";
            this._buttonOpen.Size = new System.Drawing.Size(23, 22);
            this._buttonOpen.Text = "Open NBT Data Source";
            this._buttonOpen.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // _buttonOpenFolder
            // 
            this._buttonOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonOpenFolder.Image = global::NBTExplorer.Properties.Resources.folder_open;
            this._buttonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonOpenFolder.Name = "_buttonOpenFolder";
            this._buttonOpenFolder.Size = new System.Drawing.Size(23, 22);
            this._buttonOpenFolder.Text = "Open Folder";
            this._buttonOpenFolder.Click += new System.EventHandler(this._buttonOpenFolder_Click);
            // 
            // _buttonSave
            // 
            this._buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("_buttonSave.Image")));
            this._buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(23, 22);
            this._buttonSave.Text = "Save All Modified Tags";
            this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _buttonRename
            // 
            this._buttonRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonRename.Image = ((System.Drawing.Image)(resources.GetObject("_buttonRename.Image")));
            this._buttonRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonRename.Name = "_buttonRename";
            this._buttonRename.Size = new System.Drawing.Size(23, 22);
            this._buttonRename.Text = "Rename Tag";
            this._buttonRename.Click += new System.EventHandler(this._buttonRename_Click);
            // 
            // _buttonEdit
            // 
            this._buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("_buttonEdit.Image")));
            this._buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(23, 22);
            this._buttonEdit.Text = "Edit Tag Value";
            this._buttonEdit.Click += new System.EventHandler(this._buttonEdit_Click);
            // 
            // _buttonDelete
            // 
            this._buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("_buttonDelete.Image")));
            this._buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(23, 22);
            this._buttonDelete.Text = "Delete Tag";
            this._buttonDelete.Click += new System.EventHandler(this._buttonDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _buttonAddTagByte
            // 
            this._buttonAddTagByte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagByte.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagByte.Image")));
            this._buttonAddTagByte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagByte.Name = "_buttonAddTagByte";
            this._buttonAddTagByte.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagByte.Text = "Add Byte Tag";
            this._buttonAddTagByte.Click += new System.EventHandler(this._buttonAddTagByte_Click);
            // 
            // _buttonAddTagShort
            // 
            this._buttonAddTagShort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagShort.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagShort.Image")));
            this._buttonAddTagShort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagShort.Name = "_buttonAddTagShort";
            this._buttonAddTagShort.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagShort.Text = "Add Short Tag";
            this._buttonAddTagShort.Click += new System.EventHandler(this._buttonAddTagShort_Click);
            // 
            // _buttonAddTagInt
            // 
            this._buttonAddTagInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagInt.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagInt.Image")));
            this._buttonAddTagInt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagInt.Name = "_buttonAddTagInt";
            this._buttonAddTagInt.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagInt.Text = "Add Int Tag";
            this._buttonAddTagInt.Click += new System.EventHandler(this._buttonAddTagInt_Click);
            // 
            // _buttonAddTagLong
            // 
            this._buttonAddTagLong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagLong.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagLong.Image")));
            this._buttonAddTagLong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagLong.Name = "_buttonAddTagLong";
            this._buttonAddTagLong.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagLong.Text = "Add Long Tag";
            this._buttonAddTagLong.Click += new System.EventHandler(this._buttonAddTagLong_Click);
            // 
            // _buttonAddTagFloat
            // 
            this._buttonAddTagFloat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagFloat.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagFloat.Image")));
            this._buttonAddTagFloat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagFloat.Name = "_buttonAddTagFloat";
            this._buttonAddTagFloat.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagFloat.Text = "Add Float Tag";
            this._buttonAddTagFloat.Click += new System.EventHandler(this._buttonAddTagFloat_Click);
            // 
            // _buttonAddTagDouble
            // 
            this._buttonAddTagDouble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagDouble.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagDouble.Image")));
            this._buttonAddTagDouble.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagDouble.Name = "_buttonAddTagDouble";
            this._buttonAddTagDouble.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagDouble.Text = "Add Double Tag";
            this._buttonAddTagDouble.Click += new System.EventHandler(this._buttonAddTagDouble_Click);
            // 
            // _buttonAddTagByteArray
            // 
            this._buttonAddTagByteArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagByteArray.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagByteArray.Image")));
            this._buttonAddTagByteArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagByteArray.Name = "_buttonAddTagByteArray";
            this._buttonAddTagByteArray.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagByteArray.Text = "Add Byte Array Tag";
            this._buttonAddTagByteArray.Click += new System.EventHandler(this._buttonAddTagByteArray_Click);
            // 
            // _buttonAddTagString
            // 
            this._buttonAddTagString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagString.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagString.Image")));
            this._buttonAddTagString.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagString.Name = "_buttonAddTagString";
            this._buttonAddTagString.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagString.Text = "Add String Tag";
            this._buttonAddTagString.Click += new System.EventHandler(this._buttonAddTagString_Click);
            // 
            // _buttonAddTagList
            // 
            this._buttonAddTagList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagList.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagList.Image")));
            this._buttonAddTagList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagList.Name = "_buttonAddTagList";
            this._buttonAddTagList.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagList.Text = "Add List Tag";
            this._buttonAddTagList.Click += new System.EventHandler(this._buttonAddTagList_Click);
            // 
            // _buttonAddTagCompound
            // 
            this._buttonAddTagCompound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonAddTagCompound.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAddTagCompound.Image")));
            this._buttonAddTagCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonAddTagCompound.Name = "_buttonAddTagCompound";
            this._buttonAddTagCompound.Size = new System.Drawing.Size(23, 22);
            this._buttonAddTagCompound.Text = "Add Compound Tag";
            this._buttonAddTagCompound.Click += new System.EventHandler(this._buttonAddTagCompound_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // _buttonFindNext
            // 
            this._buttonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonFindNext.Image = global::NBTExplorer.Properties.Resources.binocular__arrow;
            this._buttonFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonFindNext.Name = "_buttonFindNext";
            this._buttonFindNext.Size = new System.Drawing.Size(23, 22);
            this._buttonFindNext.Text = "Find / Find Next";
            this._buttonFindNext.Click += new System.EventHandler(this._buttonFindNext_Click);
            // 
            // _nodeContainerContext
            // 
            this._nodeContainerContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubTreeToolStripMenuItem,
            this.saveItemToolStripMenuItem});
            this._nodeContainerContext.Name = "contextMenuStrip1";
            this._nodeContainerContext.Size = new System.Drawing.Size(180, 48);
            // 
            // openSubTreeToolStripMenuItem
            // 
            this.openSubTreeToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.folder_open;
            this.openSubTreeToolStripMenuItem.Name = "openSubTreeToolStripMenuItem";
            this.openSubTreeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openSubTreeToolStripMenuItem.Text = "Open Node As Root";
            // 
            // saveItemToolStripMenuItem
            // 
            this.saveItemToolStripMenuItem.Image = global::NBTExplorer.Properties.Resources.disk;
            this.saveItemToolStripMenuItem.Name = "saveItemToolStripMenuItem";
            this.saveItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveItemToolStripMenuItem.Text = "Save Node";
            // 
            // findEntityChunkToolStripMenuItem
            // 
            this.findEntityChunkToolStripMenuItem.Name = "findEntityChunkToolStripMenuItem";
            this.findEntityChunkToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.findEntityChunkToolStripMenuItem.Text = "Find Entity Chunk";
            this.findEntityChunkToolStripMenuItem.Click += new System.EventHandler(this.findEntityChunkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 400);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NBTExplorer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._nodeContainerContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TreeView _nodeTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _buttonOpen;
        private System.Windows.Forms.ToolStripButton _buttonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _buttonRename;
        private System.Windows.Forms.ToolStripButton _buttonEdit;
        private System.Windows.Forms.ToolStripButton _buttonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _buttonAddTagByte;
        private System.Windows.Forms.ToolStripButton _buttonAddTagShort;
        private System.Windows.Forms.ToolStripButton _buttonAddTagInt;
        private System.Windows.Forms.ToolStripButton _buttonAddTagLong;
        private System.Windows.Forms.ToolStripButton _buttonAddTagFloat;
        private System.Windows.Forms.ToolStripButton _buttonAddTagDouble;
        private System.Windows.Forms.ToolStripButton _buttonAddTagByteArray;
        private System.Windows.Forms.ToolStripButton _buttonAddTagList;
        private System.Windows.Forms.ToolStripButton _buttonAddTagCompound;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton _buttonAddTagString;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _nodeContainerContext;
        private System.Windows.Forms.ToolStripMenuItem openSubTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _buttonFindNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton _buttonOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem openMinecraftSaveFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findEntityChunkToolStripMenuItem;
    }
}

