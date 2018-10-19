namespace EX1
{
    partial class InventoryScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSortByGold = new System.Windows.Forms.Button();
            this.btnSortByDefense = new System.Windows.Forms.Button();
            this.btnSortByAttack = new System.Windows.Forms.Button();
            this.btnSortByWeight = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.grpEnemyInventory = new System.Windows.Forms.GroupBox();
            this.lblSelectedItemDetails = new System.Windows.Forms.Label();
            this.picEnemySelectedItem = new System.Windows.Forms.PictureBox();
            this.lstEnemyInventory = new System.Windows.Forms.ListBox();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.lstHeroInventory = new System.Windows.Forms.ListBox();
            this.lblHeroInventoryCurrentWeight = new System.Windows.Forms.Label();
            this.lblItem1Name = new System.Windows.Forms.Label();
            this.lblHeroInventoryItemCount = new System.Windows.Forms.Label();
            this.lblHeroGold = new System.Windows.Forms.Label();
            this.lblHeroPotionName = new System.Windows.Forms.Label();
            this.lblHeroWeaponName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.lblHeroVestName = new System.Windows.Forms.Label();
            this.lblItem3Name = new System.Windows.Forms.Label();
            this.lblItem2Name = new System.Windows.Forms.Label();
            this.grpMerchantInventory = new System.Windows.Forms.GroupBox();
            this.picItem3 = new System.Windows.Forms.PictureBox();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.lblHeroHelmetName = new System.Windows.Forms.Label();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpHeroInventory = new System.Windows.Forms.GroupBox();
            this.lblHeroHp = new System.Windows.Forms.Label();
            this.picHeroSelectedItem = new System.Windows.Forms.PictureBox();
            this.picHeroPotion = new System.Windows.Forms.PictureBox();
            this.picHeroWeapon = new System.Windows.Forms.PictureBox();
            this.picHeroVest = new System.Windows.Forms.PictureBox();
            this.picHeroHelmet = new System.Windows.Forms.PictureBox();
            this.tipHeroHelmetPic = new System.Windows.Forms.ToolTip(this.components);
            this.tipHeroVestPic = new System.Windows.Forms.ToolTip(this.components);
            this.tipHeroWeaponPic = new System.Windows.Forms.ToolTip(this.components);
            this.tipHeroPotionPic = new System.Windows.Forms.ToolTip(this.components);
            this.tipMerchantItem1Pic = new System.Windows.Forms.ToolTip(this.components);
            this.tipMerchantItem2Pic = new System.Windows.Forms.ToolTip(this.components);
            this.tipMerchantItem3Pic = new System.Windows.Forms.ToolTip(this.components);
            this.tipHeroInventorySelectedItem = new System.Windows.Forms.ToolTip(this.components);
            this.tipEnemyInventorySelectedItem = new System.Windows.Forms.ToolTip(this.components);
            this.grpEnemyInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySelectedItem)).BeginInit();
            this.grpMerchantInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            this.grpHeroInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroSelectedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroVest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(6, 16);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(72, 13);
            this.lblEnemyName.TabIndex = 23;
            this.lblEnemyName.Text = "Poppy (Dead)";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(199, 310);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(26, 13);
            this.lblSort.TabIndex = 27;
            this.lblSort.Text = "Sort";
            // 
            // btnSortByGold
            // 
            this.btnSortByGold.ForeColor = System.Drawing.Color.Black;
            this.btnSortByGold.Location = new System.Drawing.Point(339, 325);
            this.btnSortByGold.Name = "btnSortByGold";
            this.btnSortByGold.Size = new System.Drawing.Size(75, 23);
            this.btnSortByGold.TabIndex = 22;
            this.btnSortByGold.Text = "Gold";
            this.btnSortByGold.UseVisualStyleBackColor = true;
            this.btnSortByGold.Click += new System.EventHandler(this.btnSortByGold_Click);
            // 
            // btnSortByDefense
            // 
            this.btnSortByDefense.ForeColor = System.Drawing.Color.Black;
            this.btnSortByDefense.Location = new System.Drawing.Point(258, 325);
            this.btnSortByDefense.Name = "btnSortByDefense";
            this.btnSortByDefense.Size = new System.Drawing.Size(75, 23);
            this.btnSortByDefense.TabIndex = 21;
            this.btnSortByDefense.Text = "Defense";
            this.btnSortByDefense.UseVisualStyleBackColor = true;
            this.btnSortByDefense.Click += new System.EventHandler(this.btnSortByDefense_Click);
            // 
            // btnSortByAttack
            // 
            this.btnSortByAttack.ForeColor = System.Drawing.Color.Black;
            this.btnSortByAttack.Location = new System.Drawing.Point(177, 325);
            this.btnSortByAttack.Name = "btnSortByAttack";
            this.btnSortByAttack.Size = new System.Drawing.Size(75, 23);
            this.btnSortByAttack.TabIndex = 20;
            this.btnSortByAttack.Text = "Attack";
            this.btnSortByAttack.UseVisualStyleBackColor = true;
            this.btnSortByAttack.Click += new System.EventHandler(this.btnSortByAttack_Click);
            // 
            // btnSortByWeight
            // 
            this.btnSortByWeight.ForeColor = System.Drawing.Color.Black;
            this.btnSortByWeight.Location = new System.Drawing.Point(96, 325);
            this.btnSortByWeight.Name = "btnSortByWeight";
            this.btnSortByWeight.Size = new System.Drawing.Size(75, 23);
            this.btnSortByWeight.TabIndex = 19;
            this.btnSortByWeight.Text = "Weight";
            this.btnSortByWeight.UseVisualStyleBackColor = true;
            this.btnSortByWeight.Click += new System.EventHandler(this.btnSortByWeight_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.ForeColor = System.Drawing.Color.Black;
            this.btnSortByName.Location = new System.Drawing.Point(15, 325);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(75, 23);
            this.btnSortByName.TabIndex = 18;
            this.btnSortByName.Text = "Name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.ForeColor = System.Drawing.Color.Black;
            this.btnOptimize.Location = new System.Drawing.Point(346, 284);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(75, 23);
            this.btnOptimize.TabIndex = 17;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // btnUse
            // 
            this.btnUse.ForeColor = System.Drawing.Color.Black;
            this.btnUse.Location = new System.Drawing.Point(346, 236);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 16;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnTake
            // 
            this.btnTake.ForeColor = System.Drawing.Color.Black;
            this.btnTake.Location = new System.Drawing.Point(198, 203);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(123, 23);
            this.btnTake.TabIndex = 26;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // grpEnemyInventory
            // 
            this.grpEnemyInventory.BackColor = System.Drawing.Color.Transparent;
            this.grpEnemyInventory.Controls.Add(this.lblSelectedItemDetails);
            this.grpEnemyInventory.Controls.Add(this.btnTake);
            this.grpEnemyInventory.Controls.Add(this.picEnemySelectedItem);
            this.grpEnemyInventory.Controls.Add(this.lstEnemyInventory);
            this.grpEnemyInventory.Controls.Add(this.lblEnemyName);
            this.grpEnemyInventory.ForeColor = System.Drawing.Color.White;
            this.grpEnemyInventory.Location = new System.Drawing.Point(446, 132);
            this.grpEnemyInventory.Name = "grpEnemyInventory";
            this.grpEnemyInventory.Size = new System.Drawing.Size(343, 237);
            this.grpEnemyInventory.TabIndex = 27;
            this.grpEnemyInventory.TabStop = false;
            this.grpEnemyInventory.Text = "Enemy Inventory";
            // 
            // lblSelectedItemDetails
            // 
            this.lblSelectedItemDetails.AutoSize = true;
            this.lblSelectedItemDetails.Location = new System.Drawing.Point(195, 188);
            this.lblSelectedItemDetails.Name = "lblSelectedItemDetails";
            this.lblSelectedItemDetails.Size = new System.Drawing.Size(33, 13);
            this.lblSelectedItemDetails.TabIndex = 33;
            this.lblSelectedItemDetails.Text = "(type)";
            // 
            // picEnemySelectedItem
            // 
            this.picEnemySelectedItem.Location = new System.Drawing.Point(198, 40);
            this.picEnemySelectedItem.Name = "picEnemySelectedItem";
            this.picEnemySelectedItem.Size = new System.Drawing.Size(123, 145);
            this.picEnemySelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemySelectedItem.TabIndex = 25;
            this.picEnemySelectedItem.TabStop = false;
            // 
            // lstEnemyInventory
            // 
            this.lstEnemyInventory.FormattingEnabled = true;
            this.lstEnemyInventory.Location = new System.Drawing.Point(9, 40);
            this.lstEnemyInventory.Name = "lstEnemyInventory";
            this.lstEnemyInventory.Size = new System.Drawing.Size(162, 186);
            this.lstEnemyInventory.TabIndex = 24;
            this.lstEnemyInventory.SelectedIndexChanged += new System.EventHandler(this.lstEnemyInventory_SelectedIndexChanged);
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.Location = new System.Drawing.Point(6, 16);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(55, 13);
            this.lblMerchantName.TabIndex = 26;
            this.lblMerchantName.Text = "Katy Perry";
            // 
            // btnDrop
            // 
            this.btnDrop.ForeColor = System.Drawing.Color.Black;
            this.btnDrop.Location = new System.Drawing.Point(346, 183);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(75, 23);
            this.btnDrop.TabIndex = 15;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnSell
            // 
            this.btnSell.ForeColor = System.Drawing.Color.Black;
            this.btnSell.Location = new System.Drawing.Point(346, 123);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 14;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.ForeColor = System.Drawing.Color.Black;
            this.btnEquip.Location = new System.Drawing.Point(346, 72);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(75, 23);
            this.btnEquip.TabIndex = 13;
            this.btnEquip.Text = "Equip";
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // lstHeroInventory
            // 
            this.lstHeroInventory.FormattingEnabled = true;
            this.lstHeroInventory.Location = new System.Drawing.Point(134, 69);
            this.lstHeroInventory.Name = "lstHeroInventory";
            this.lstHeroInventory.Size = new System.Drawing.Size(190, 238);
            this.lstHeroInventory.TabIndex = 12;
            this.lstHeroInventory.SelectedIndexChanged += new System.EventHandler(this.lstHeroInventory_SelectedIndexChanged);
            // 
            // lblHeroInventoryCurrentWeight
            // 
            this.lblHeroInventoryCurrentWeight.AutoSize = true;
            this.lblHeroInventoryCurrentWeight.Location = new System.Drawing.Point(276, 45);
            this.lblHeroInventoryCurrentWeight.Name = "lblHeroInventoryCurrentWeight";
            this.lblHeroInventoryCurrentWeight.Size = new System.Drawing.Size(44, 13);
            this.lblHeroInventoryCurrentWeight.TabIndex = 11;
            this.lblHeroInventoryCurrentWeight.Text = "27.2 lbs";
            // 
            // lblItem1Name
            // 
            this.lblItem1Name.Location = new System.Drawing.Point(6, 85);
            this.lblItem1Name.Name = "lblItem1Name";
            this.lblItem1Name.Size = new System.Drawing.Size(100, 23);
            this.lblItem1Name.TabIndex = 28;
            this.lblItem1Name.Text = "Item1 Name";
            // 
            // lblHeroInventoryItemCount
            // 
            this.lblHeroInventoryItemCount.AutoSize = true;
            this.lblHeroInventoryItemCount.Location = new System.Drawing.Point(208, 45);
            this.lblHeroInventoryItemCount.Name = "lblHeroInventoryItemCount";
            this.lblHeroInventoryItemCount.Size = new System.Drawing.Size(30, 13);
            this.lblHeroInventoryItemCount.TabIndex = 10;
            this.lblHeroInventoryItemCount.Text = "4/20";
            // 
            // lblHeroGold
            // 
            this.lblHeroGold.AutoSize = true;
            this.lblHeroGold.Location = new System.Drawing.Point(131, 45);
            this.lblHeroGold.Name = "lblHeroGold";
            this.lblHeroGold.Size = new System.Drawing.Size(50, 13);
            this.lblHeroGold.TabIndex = 9;
            this.lblHeroGold.Text = "100 Gold";
            // 
            // lblHeroPotionName
            // 
            this.lblHeroPotionName.AutoSize = true;
            this.lblHeroPotionName.Location = new System.Drawing.Point(6, 305);
            this.lblHeroPotionName.Name = "lblHeroPotionName";
            this.lblHeroPotionName.Size = new System.Drawing.Size(114, 13);
            this.lblHeroPotionName.TabIndex = 8;
            this.lblHeroPotionName.Text = "Tyler Durden\'s Hair gel";
            // 
            // lblHeroWeaponName
            // 
            this.lblHeroWeaponName.AutoSize = true;
            this.lblHeroWeaponName.Location = new System.Drawing.Point(6, 236);
            this.lblHeroWeaponName.Name = "lblHeroWeaponName";
            this.lblHeroWeaponName.Size = new System.Drawing.Size(94, 13);
            this.lblHeroWeaponName.TabIndex = 6;
            this.lblHeroWeaponName.Text = "Tyler Durden\'s Fist";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(714, 388);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Location = new System.Drawing.Point(13, 388);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(75, 23);
            this.btnNextLevel.TabIndex = 30;
            this.btnNextLevel.Text = "Next Level";
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // lblHeroVestName
            // 
            this.lblHeroVestName.AutoSize = true;
            this.lblHeroVestName.Location = new System.Drawing.Point(6, 167);
            this.lblHeroVestName.Name = "lblHeroVestName";
            this.lblHeroVestName.Size = new System.Drawing.Size(96, 13);
            this.lblHeroVestName.TabIndex = 4;
            this.lblHeroVestName.Text = "Tyler Durden\'s Abs";
            // 
            // lblItem3Name
            // 
            this.lblItem3Name.Location = new System.Drawing.Point(218, 85);
            this.lblItem3Name.Name = "lblItem3Name";
            this.lblItem3Name.Size = new System.Drawing.Size(100, 23);
            this.lblItem3Name.TabIndex = 32;
            this.lblItem3Name.Text = "Item3 Name";
            // 
            // lblItem2Name
            // 
            this.lblItem2Name.Location = new System.Drawing.Point(112, 85);
            this.lblItem2Name.Name = "lblItem2Name";
            this.lblItem2Name.Size = new System.Drawing.Size(100, 23);
            this.lblItem2Name.TabIndex = 30;
            this.lblItem2Name.Text = "Item2 Name";
            // 
            // grpMerchantInventory
            // 
            this.grpMerchantInventory.BackColor = System.Drawing.Color.Transparent;
            this.grpMerchantInventory.Controls.Add(this.lblItem3Name);
            this.grpMerchantInventory.Controls.Add(this.picItem3);
            this.grpMerchantInventory.Controls.Add(this.lblItem2Name);
            this.grpMerchantInventory.Controls.Add(this.picItem2);
            this.grpMerchantInventory.Controls.Add(this.lblItem1Name);
            this.grpMerchantInventory.Controls.Add(this.picItem1);
            this.grpMerchantInventory.Controls.Add(this.lblMerchantName);
            this.grpMerchantInventory.ForeColor = System.Drawing.Color.White;
            this.grpMerchantInventory.Location = new System.Drawing.Point(446, 15);
            this.grpMerchantInventory.Name = "grpMerchantInventory";
            this.grpMerchantInventory.Size = new System.Drawing.Size(343, 111);
            this.grpMerchantInventory.TabIndex = 28;
            this.grpMerchantInventory.TabStop = false;
            this.grpMerchantInventory.Text = "Wandering Merchant Inventory";
            // 
            // picItem3
            // 
            this.picItem3.Location = new System.Drawing.Point(221, 32);
            this.picItem3.Name = "picItem3";
            this.picItem3.Size = new System.Drawing.Size(100, 50);
            this.picItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem3.TabIndex = 31;
            this.picItem3.TabStop = false;
            this.picItem3.Click += new System.EventHandler(this.picItem3_Click);
            // 
            // picItem2
            // 
            this.picItem2.Location = new System.Drawing.Point(115, 32);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(100, 50);
            this.picItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem2.TabIndex = 29;
            this.picItem2.TabStop = false;
            this.picItem2.Click += new System.EventHandler(this.picItem2_Click);
            // 
            // picItem1
            // 
            this.picItem1.Location = new System.Drawing.Point(9, 32);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(100, 50);
            this.picItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem1.TabIndex = 27;
            this.picItem1.TabStop = false;
            this.picItem1.Click += new System.EventHandler(this.picItem1_Click);
            // 
            // lblHeroHelmetName
            // 
            this.lblHeroHelmetName.AutoSize = true;
            this.lblHeroHelmetName.Location = new System.Drawing.Point(6, 98);
            this.lblHeroHelmetName.Name = "lblHeroHelmetName";
            this.lblHeroHelmetName.Size = new System.Drawing.Size(98, 13);
            this.lblHeroHelmetName.TabIndex = 2;
            this.lblHeroHelmetName.Text = "Tyler Durdens Flow";
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Location = new System.Drawing.Point(6, 16);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(68, 13);
            this.lblHeroName.TabIndex = 0;
            this.lblHeroName.Text = "Tyler Durden";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpHeroInventory
            // 
            this.grpHeroInventory.BackColor = System.Drawing.Color.Transparent;
            this.grpHeroInventory.Controls.Add(this.lblHeroHp);
            this.grpHeroInventory.Controls.Add(this.picHeroSelectedItem);
            this.grpHeroInventory.Controls.Add(this.lblSort);
            this.grpHeroInventory.Controls.Add(this.btnSortByGold);
            this.grpHeroInventory.Controls.Add(this.btnSortByDefense);
            this.grpHeroInventory.Controls.Add(this.btnSortByAttack);
            this.grpHeroInventory.Controls.Add(this.btnSortByWeight);
            this.grpHeroInventory.Controls.Add(this.btnSortByName);
            this.grpHeroInventory.Controls.Add(this.btnOptimize);
            this.grpHeroInventory.Controls.Add(this.btnUse);
            this.grpHeroInventory.Controls.Add(this.btnDrop);
            this.grpHeroInventory.Controls.Add(this.btnSell);
            this.grpHeroInventory.Controls.Add(this.btnEquip);
            this.grpHeroInventory.Controls.Add(this.lstHeroInventory);
            this.grpHeroInventory.Controls.Add(this.lblHeroInventoryCurrentWeight);
            this.grpHeroInventory.Controls.Add(this.lblHeroInventoryItemCount);
            this.grpHeroInventory.Controls.Add(this.lblHeroGold);
            this.grpHeroInventory.Controls.Add(this.lblHeroPotionName);
            this.grpHeroInventory.Controls.Add(this.picHeroPotion);
            this.grpHeroInventory.Controls.Add(this.lblHeroWeaponName);
            this.grpHeroInventory.Controls.Add(this.picHeroWeapon);
            this.grpHeroInventory.Controls.Add(this.lblHeroVestName);
            this.grpHeroInventory.Controls.Add(this.picHeroVest);
            this.grpHeroInventory.Controls.Add(this.lblHeroHelmetName);
            this.grpHeroInventory.Controls.Add(this.picHeroHelmet);
            this.grpHeroInventory.Controls.Add(this.lblHeroName);
            this.grpHeroInventory.ForeColor = System.Drawing.Color.White;
            this.grpHeroInventory.Location = new System.Drawing.Point(13, 15);
            this.grpHeroInventory.Name = "grpHeroInventory";
            this.grpHeroInventory.Size = new System.Drawing.Size(427, 354);
            this.grpHeroInventory.TabIndex = 29;
            this.grpHeroInventory.TabStop = false;
            this.grpHeroInventory.Text = "Hero Inventory";
            // 
            // lblHeroHp
            // 
            this.lblHeroHp.AutoSize = true;
            this.lblHeroHp.Location = new System.Drawing.Point(136, 16);
            this.lblHeroHp.Name = "lblHeroHp";
            this.lblHeroHp.Size = new System.Drawing.Size(40, 13);
            this.lblHeroHp.TabIndex = 33;
            this.lblHeroHp.Text = "HP: 48";
            // 
            // picHeroSelectedItem
            // 
            this.picHeroSelectedItem.Location = new System.Drawing.Point(326, 8);
            this.picHeroSelectedItem.Name = "picHeroSelectedItem";
            this.picHeroSelectedItem.Size = new System.Drawing.Size(100, 50);
            this.picHeroSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroSelectedItem.TabIndex = 34;
            this.picHeroSelectedItem.TabStop = false;
            // 
            // picHeroPotion
            // 
            this.picHeroPotion.Location = new System.Drawing.Point(9, 252);
            this.picHeroPotion.Name = "picHeroPotion";
            this.picHeroPotion.Size = new System.Drawing.Size(100, 50);
            this.picHeroPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroPotion.TabIndex = 7;
            this.picHeroPotion.TabStop = false;
            this.picHeroPotion.Click += new System.EventHandler(this.picHeroPotion_Click);
            // 
            // picHeroWeapon
            // 
            this.picHeroWeapon.Location = new System.Drawing.Point(9, 183);
            this.picHeroWeapon.Name = "picHeroWeapon";
            this.picHeroWeapon.Size = new System.Drawing.Size(100, 50);
            this.picHeroWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroWeapon.TabIndex = 5;
            this.picHeroWeapon.TabStop = false;
            this.picHeroWeapon.Click += new System.EventHandler(this.picHeroWeapon_Click);
            // 
            // picHeroVest
            // 
            this.picHeroVest.Location = new System.Drawing.Point(9, 114);
            this.picHeroVest.Name = "picHeroVest";
            this.picHeroVest.Size = new System.Drawing.Size(100, 50);
            this.picHeroVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroVest.TabIndex = 3;
            this.picHeroVest.TabStop = false;
            this.picHeroVest.Click += new System.EventHandler(this.picHeroVest_Click);
            // 
            // picHeroHelmet
            // 
            this.picHeroHelmet.Location = new System.Drawing.Point(9, 45);
            this.picHeroHelmet.Name = "picHeroHelmet";
            this.picHeroHelmet.Size = new System.Drawing.Size(100, 50);
            this.picHeroHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroHelmet.TabIndex = 1;
            this.picHeroHelmet.TabStop = false;
            this.picHeroHelmet.Click += new System.EventHandler(this.picHeroHelmet_Click);
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EX1.Properties.Resources.Dungeon_Master;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.grpEnemyInventory);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNextLevel);
            this.Controls.Add(this.grpMerchantInventory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpHeroInventory);
            this.Name = "InventoryScreen";
            this.Size = new System.Drawing.Size(814, 430);
            this.VisibleChanged += new System.EventHandler(this.InventoryScreen_VisibleChanged);
            this.grpEnemyInventory.ResumeLayout(false);
            this.grpEnemyInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySelectedItem)).EndInit();
            this.grpMerchantInventory.ResumeLayout(false);
            this.grpMerchantInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            this.grpHeroInventory.ResumeLayout(false);
            this.grpHeroInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroSelectedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroVest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroHelmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSortByGold;
        private System.Windows.Forms.Button btnSortByDefense;
        private System.Windows.Forms.Button btnSortByAttack;
        private System.Windows.Forms.Button btnSortByWeight;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.PictureBox picEnemySelectedItem;
        private System.Windows.Forms.GroupBox grpEnemyInventory;
        private System.Windows.Forms.ListBox lstEnemyInventory;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.ListBox lstHeroInventory;
        private System.Windows.Forms.Label lblHeroInventoryCurrentWeight;
        private System.Windows.Forms.Label lblItem1Name;
        private System.Windows.Forms.Label lblHeroInventoryItemCount;
        private System.Windows.Forms.Label lblHeroGold;
        private System.Windows.Forms.Label lblHeroPotionName;
        private System.Windows.Forms.PictureBox picHeroPotion;
        private System.Windows.Forms.Label lblHeroWeaponName;
        private System.Windows.Forms.PictureBox picHeroWeapon;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Label lblHeroVestName;
        private System.Windows.Forms.Label lblItem3Name;
        private System.Windows.Forms.PictureBox picItem3;
        private System.Windows.Forms.Label lblItem2Name;
        private System.Windows.Forms.GroupBox grpMerchantInventory;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.PictureBox picHeroVest;
        private System.Windows.Forms.Label lblHeroHelmetName;
        private System.Windows.Forms.PictureBox picHeroHelmet;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpHeroInventory;
        private System.Windows.Forms.Label lblSelectedItemDetails;
        private System.Windows.Forms.ToolTip tipHeroHelmetPic;
        private System.Windows.Forms.ToolTip tipHeroVestPic;
        private System.Windows.Forms.ToolTip tipHeroWeaponPic;
        private System.Windows.Forms.ToolTip tipHeroPotionPic;
        private System.Windows.Forms.ToolTip tipMerchantItem1Pic;
        private System.Windows.Forms.ToolTip tipMerchantItem2Pic;
        private System.Windows.Forms.ToolTip tipMerchantItem3Pic;
        private System.Windows.Forms.ToolTip tipHeroInventorySelectedItem;
        private System.Windows.Forms.ToolTip tipEnemyInventorySelectedItem;
        private System.Windows.Forms.PictureBox picHeroSelectedItem;
        private System.Windows.Forms.Label lblHeroHp;
    }
}
