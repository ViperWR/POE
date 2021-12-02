
namespace GADE_POE_task_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MapLabel = new System.Windows.Forms.Label();
            this.buttonUP1 = new System.Windows.Forms.Button();
            this.buttonRIGHT1 = new System.Windows.Forms.Button();
            this.buttonLEFT1 = new System.Windows.Forms.Button();
            this.buttonDown1 = new System.Windows.Forms.Button();
            this.groupBoxAttacking = new System.Windows.Forms.GroupBox();
            this.richTextBox_Item_Pickup = new System.Windows.Forms.RichTextBox();
            this.attack_richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_Attack = new System.Windows.Forms.Button();
            this.groupBox_Player_Stats = new System.Windows.Forms.GroupBox();
            this.richTextBox_Player_Stats = new System.Windows.Forms.RichTextBox();
            this.select_enemy = new System.Windows.Forms.ComboBox();
            this.labelAttack = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.equip_weapon = new System.Windows.Forms.ComboBox();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.groupBoxWeapon = new System.Windows.Forms.GroupBox();
            this.groupBoxWeaponStats = new System.Windows.Forms.GroupBox();
            this.richTextBoxWeaponStats = new System.Windows.Forms.RichTextBox();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.richTextBoxInventoryRanged = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInventoryMelee = new System.Windows.Forms.RichTextBox();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.groupBoxShopHistory = new System.Windows.Forms.GroupBox();
            this.richTextBoxShop = new System.Windows.Forms.RichTextBox();
            this.labelBuy = new System.Windows.Forms.Label();
            this.comboBoxShopItems = new System.Windows.Forms.ComboBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.groupBoxAttacking.SuspendLayout();
            this.groupBox_Player_Stats.SuspendLayout();
            this.groupBoxWeapon.SuspendLayout();
            this.groupBoxWeaponStats.SuspendLayout();
            this.groupBoxInventory.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            this.groupBoxShopHistory.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapLabel
            // 
            this.MapLabel.AccessibleName = "MapLabel";
            this.MapLabel.AutoSize = true;
            this.MapLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapLabel.Location = new System.Drawing.Point(123, 35);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(38, 18);
            this.MapLabel.TabIndex = 0;
            this.MapLabel.Text = "Map";
            this.MapLabel.Click += new System.EventHandler(this.MapLabel_Click);
            // 
            // buttonUP1
            // 
            this.buttonUP1.Location = new System.Drawing.Point(290, 412);
            this.buttonUP1.Name = "buttonUP1";
            this.buttonUP1.Size = new System.Drawing.Size(40, 23);
            this.buttonUP1.TabIndex = 2;
            this.buttonUP1.Text = "^";
            this.buttonUP1.UseVisualStyleBackColor = true;
            this.buttonUP1.Click += new System.EventHandler(this.buttonUP1_Click);
            // 
            // buttonRIGHT1
            // 
            this.buttonRIGHT1.Location = new System.Drawing.Point(343, 439);
            this.buttonRIGHT1.Name = "buttonRIGHT1";
            this.buttonRIGHT1.Size = new System.Drawing.Size(40, 23);
            this.buttonRIGHT1.TabIndex = 3;
            this.buttonRIGHT1.Text = ">";
            this.buttonRIGHT1.UseVisualStyleBackColor = true;
            this.buttonRIGHT1.Click += new System.EventHandler(this.buttonRIGHT1_Click);
            // 
            // buttonLEFT1
            // 
            this.buttonLEFT1.Location = new System.Drawing.Point(235, 439);
            this.buttonLEFT1.Name = "buttonLEFT1";
            this.buttonLEFT1.Size = new System.Drawing.Size(40, 23);
            this.buttonLEFT1.TabIndex = 4;
            this.buttonLEFT1.Text = "<";
            this.buttonLEFT1.UseVisualStyleBackColor = true;
            this.buttonLEFT1.Click += new System.EventHandler(this.buttonLEFT1_Click);
            // 
            // buttonDown1
            // 
            this.buttonDown1.Location = new System.Drawing.Point(290, 471);
            this.buttonDown1.Name = "buttonDown1";
            this.buttonDown1.Size = new System.Drawing.Size(40, 23);
            this.buttonDown1.TabIndex = 5;
            this.buttonDown1.Text = "v";
            this.buttonDown1.UseVisualStyleBackColor = true;
            this.buttonDown1.Click += new System.EventHandler(this.buttonDown1_Click);
            // 
            // groupBoxAttacking
            // 
            this.groupBoxAttacking.Controls.Add(this.richTextBox_Item_Pickup);
            this.groupBoxAttacking.Controls.Add(this.attack_richTextBox);
            this.groupBoxAttacking.Controls.Add(this.button_Attack);
            this.groupBoxAttacking.Location = new System.Drawing.Point(461, 117);
            this.groupBoxAttacking.Name = "groupBoxAttacking";
            this.groupBoxAttacking.Size = new System.Drawing.Size(216, 371);
            this.groupBoxAttacking.TabIndex = 6;
            this.groupBoxAttacking.TabStop = false;
            this.groupBoxAttacking.Text = "Attacking";
            this.groupBoxAttacking.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // richTextBox_Item_Pickup
            // 
            this.richTextBox_Item_Pickup.Location = new System.Drawing.Point(6, 295);
            this.richTextBox_Item_Pickup.Name = "richTextBox_Item_Pickup";
            this.richTextBox_Item_Pickup.Size = new System.Drawing.Size(204, 70);
            this.richTextBox_Item_Pickup.TabIndex = 2;
            this.richTextBox_Item_Pickup.Text = "";
            // 
            // attack_richTextBox
            // 
            this.attack_richTextBox.Location = new System.Drawing.Point(6, 22);
            this.attack_richTextBox.Name = "attack_richTextBox";
            this.attack_richTextBox.Size = new System.Drawing.Size(204, 222);
            this.attack_richTextBox.TabIndex = 1;
            this.attack_richTextBox.Text = "";
            // 
            // button_Attack
            // 
            this.button_Attack.Location = new System.Drawing.Point(6, 250);
            this.button_Attack.Name = "button_Attack";
            this.button_Attack.Size = new System.Drawing.Size(204, 39);
            this.button_Attack.TabIndex = 0;
            this.button_Attack.Text = "Attack";
            this.button_Attack.UseVisualStyleBackColor = true;
            this.button_Attack.Click += new System.EventHandler(this.button_Attack_Click);
            // 
            // groupBox_Player_Stats
            // 
            this.groupBox_Player_Stats.Controls.Add(this.richTextBox_Player_Stats);
            this.groupBox_Player_Stats.Location = new System.Drawing.Point(461, 12);
            this.groupBox_Player_Stats.Name = "groupBox_Player_Stats";
            this.groupBox_Player_Stats.Size = new System.Drawing.Size(216, 105);
            this.groupBox_Player_Stats.TabIndex = 8;
            this.groupBox_Player_Stats.TabStop = false;
            this.groupBox_Player_Stats.Text = "Player Stats";
            // 
            // richTextBox_Player_Stats
            // 
            this.richTextBox_Player_Stats.Location = new System.Drawing.Point(6, 22);
            this.richTextBox_Player_Stats.Name = "richTextBox_Player_Stats";
            this.richTextBox_Player_Stats.Size = new System.Drawing.Size(204, 76);
            this.richTextBox_Player_Stats.TabIndex = 0;
            this.richTextBox_Player_Stats.Text = "";
            this.richTextBox_Player_Stats.TextChanged += new System.EventHandler(this.richTextBox_Player_Stats_TextChanged);
            // 
            // select_enemy
            // 
            this.select_enemy.FormattingEnabled = true;
            this.select_enemy.Items.AddRange(new object[] {
            "Above you",
            "Under you",
            "On your Right",
            "On your Left"});
            this.select_enemy.Location = new System.Drawing.Point(59, 403);
            this.select_enemy.Name = "select_enemy";
            this.select_enemy.Size = new System.Drawing.Size(121, 23);
            this.select_enemy.TabIndex = 9;
            this.select_enemy.SelectedIndexChanged += new System.EventHandler(this.select_enemy_SelectedIndexChanged);
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(12, 406);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(41, 15);
            this.labelAttack.TabIndex = 10;
            this.labelAttack.Text = "Attack";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(59, 457);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(59, 486);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(121, 23);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // equip_weapon
            // 
            this.equip_weapon.FormattingEnabled = true;
            this.equip_weapon.Items.AddRange(new object[] {
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands",
            "Bare Hands"});
            this.equip_weapon.Location = new System.Drawing.Point(113, 22);
            this.equip_weapon.Name = "equip_weapon";
            this.equip_weapon.Size = new System.Drawing.Size(121, 23);
            this.equip_weapon.TabIndex = 13;
            this.equip_weapon.SelectedIndexChanged += new System.EventHandler(this.equip_weapon_SelectedIndexChanged);
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Location = new System.Drawing.Point(32, 25);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(50, 15);
            this.labelWeapon.TabIndex = 14;
            this.labelWeapon.Text = "Equiped";
            // 
            // groupBoxWeapon
            // 
            this.groupBoxWeapon.Controls.Add(this.groupBoxWeaponStats);
            this.groupBoxWeapon.Controls.Add(this.equip_weapon);
            this.groupBoxWeapon.Controls.Add(this.labelWeapon);
            this.groupBoxWeapon.Location = new System.Drawing.Point(696, 147);
            this.groupBoxWeapon.Name = "groupBoxWeapon";
            this.groupBoxWeapon.Size = new System.Drawing.Size(276, 146);
            this.groupBoxWeapon.TabIndex = 15;
            this.groupBoxWeapon.TabStop = false;
            this.groupBoxWeapon.Text = "Weapon";
            this.groupBoxWeapon.Enter += new System.EventHandler(this.groupBoxWeapon_Enter);
            // 
            // groupBoxWeaponStats
            // 
            this.groupBoxWeaponStats.Controls.Add(this.richTextBoxWeaponStats);
            this.groupBoxWeaponStats.Location = new System.Drawing.Point(32, 51);
            this.groupBoxWeaponStats.Name = "groupBoxWeaponStats";
            this.groupBoxWeaponStats.Size = new System.Drawing.Size(223, 85);
            this.groupBoxWeaponStats.TabIndex = 15;
            this.groupBoxWeaponStats.TabStop = false;
            this.groupBoxWeaponStats.Text = "Stats";
            // 
            // richTextBoxWeaponStats
            // 
            this.richTextBoxWeaponStats.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxWeaponStats.Name = "richTextBoxWeaponStats";
            this.richTextBoxWeaponStats.Size = new System.Drawing.Size(211, 57);
            this.richTextBoxWeaponStats.TabIndex = 1;
            this.richTextBoxWeaponStats.Text = "Damage : 2\nRange : 1\nDurability : ∞";
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Controls.Add(this.richTextBoxInventoryRanged);
            this.groupBoxInventory.Controls.Add(this.richTextBoxInventoryMelee);
            this.groupBoxInventory.Location = new System.Drawing.Point(696, 12);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(276, 121);
            this.groupBoxInventory.TabIndex = 16;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Inventory";
            // 
            // richTextBoxInventoryRanged
            // 
            this.richTextBoxInventoryRanged.Location = new System.Drawing.Point(6, 72);
            this.richTextBoxInventoryRanged.Name = "richTextBoxInventoryRanged";
            this.richTextBoxInventoryRanged.Size = new System.Drawing.Size(264, 43);
            this.richTextBoxInventoryRanged.TabIndex = 4;
            this.richTextBoxInventoryRanged.Text = "Ranged :";
            // 
            // richTextBoxInventoryMelee
            // 
            this.richTextBoxInventoryMelee.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxInventoryMelee.Name = "richTextBoxInventoryMelee";
            this.richTextBoxInventoryMelee.Size = new System.Drawing.Size(264, 44);
            this.richTextBoxInventoryMelee.TabIndex = 3;
            this.richTextBoxInventoryMelee.Text = "Melee :";
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.groupBoxShopHistory);
            this.groupBoxShop.Controls.Add(this.labelBuy);
            this.groupBoxShop.Controls.Add(this.comboBoxShopItems);
            this.groupBoxShop.Location = new System.Drawing.Point(696, 299);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(276, 141);
            this.groupBoxShop.TabIndex = 17;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "Shop";
            // 
            // groupBoxShopHistory
            // 
            this.groupBoxShopHistory.Controls.Add(this.richTextBoxShop);
            this.groupBoxShopHistory.Location = new System.Drawing.Point(32, 56);
            this.groupBoxShopHistory.Name = "groupBoxShopHistory";
            this.groupBoxShopHistory.Size = new System.Drawing.Size(223, 79);
            this.groupBoxShopHistory.TabIndex = 17;
            this.groupBoxShopHistory.TabStop = false;
            this.groupBoxShopHistory.Text = "Buy History";
            // 
            // richTextBoxShop
            // 
            this.richTextBoxShop.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxShop.Name = "richTextBoxShop";
            this.richTextBoxShop.Size = new System.Drawing.Size(211, 57);
            this.richTextBoxShop.TabIndex = 2;
            this.richTextBoxShop.Text = "";
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.Location = new System.Drawing.Point(38, 30);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(27, 15);
            this.labelBuy.TabIndex = 16;
            this.labelBuy.Text = "Buy";
            // 
            // comboBoxShopItems
            // 
            this.comboBoxShopItems.FormattingEnabled = true;
            this.comboBoxShopItems.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.comboBoxShopItems.Location = new System.Drawing.Point(113, 27);
            this.comboBoxShopItems.Name = "comboBoxShopItems";
            this.comboBoxShopItems.Size = new System.Drawing.Size(121, 23);
            this.comboBoxShopItems.TabIndex = 16;
            this.comboBoxShopItems.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            this.comboBoxShopItems.TextChanged += new System.EventHandler(this.comboBoxShopItems_SelectedIndexChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Enabled = false;
            this.buttonBuy.Location = new System.Drawing.Point(696, 455);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(276, 33);
            this.buttonBuy.TabIndex = 18;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.richTextBoxInfo);
            this.groupBoxInfo.Location = new System.Drawing.Point(990, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(177, 489);
            this.groupBoxInfo.TabIndex = 19;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(6, 23);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(164, 459);
            this.richTextBoxInfo.TabIndex = 1;
            this.richTextBoxInfo.Text = resources.GetString("richTextBoxInfo.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 513);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.groupBoxInventory);
            this.Controls.Add(this.groupBoxWeapon);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.select_enemy);
            this.Controls.Add(this.groupBox_Player_Stats);
            this.Controls.Add(this.groupBoxAttacking);
            this.Controls.Add(this.buttonDown1);
            this.Controls.Add(this.buttonLEFT1);
            this.Controls.Add(this.buttonRIGHT1);
            this.Controls.Add(this.buttonUP1);
            this.Controls.Add(this.MapLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAttacking.ResumeLayout(false);
            this.groupBox_Player_Stats.ResumeLayout(false);
            this.groupBoxWeapon.ResumeLayout(false);
            this.groupBoxWeapon.PerformLayout();
            this.groupBoxWeaponStats.ResumeLayout(false);
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxShop.PerformLayout();
            this.groupBoxShopHistory.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonUP1;
        private System.Windows.Forms.Button buttonRIGHT1;
        private System.Windows.Forms.Button buttonLEFT1;
        private System.Windows.Forms.Button buttonDown1;
        private System.Windows.Forms.GroupBox groupBoxAttacking;
        private System.Windows.Forms.Button button_Attack;
        private System.Windows.Forms.RichTextBox richTextBox_Item_Pickup;
        private System.Windows.Forms.RichTextBox attack_richTextBox;
        private System.Windows.Forms.GroupBox groupBox_Player_Stats;
        private System.Windows.Forms.RichTextBox richTextBox_Player_Stats;
        private System.Windows.Forms.ComboBox select_enemy;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        public System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.ComboBox equip_weapon;
        private System.Windows.Forms.Label labelWeapon;
        private System.Windows.Forms.GroupBox groupBoxWeapon;
        private System.Windows.Forms.GroupBox groupBoxWeaponStats;
        private System.Windows.Forms.RichTextBox richTextBoxWeaponStats;
        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.RichTextBox richTextBoxInventoryMelee;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.GroupBox groupBoxShopHistory;
        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.RichTextBox richTextBoxInventoryRanged;
        private System.Windows.Forms.RichTextBox richTextBoxShopItems;
        public System.Windows.Forms.RichTextBox richTextBoxShop;
        public System.Windows.Forms.ComboBox comboBoxShopItems;
        public System.Windows.Forms.Button buttonBuy;
    }
}

