using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class InventoryScreen : UserControl
    {
        private RogueliteForm _roguelite;
        private ItemFactory _itemFactory;
        
        private Game _currentGame;
        private Character _hero;
        private Character _enemy;
        private Item _item1;
        private Item _item2;
        private Item _item3;

        public InventoryScreen()
        {
            InitializeComponent();
            _itemFactory = new ItemFactory();
        }
        public RogueliteForm Roguelite
        {
            get { return _roguelite; }
            set { _roguelite = value; }
        }
        private void InventoryScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && _roguelite != null)
            {
                _currentGame = _roguelite.CurrentGame;
                _hero = _currentGame.Player;
                _enemy = _currentGame.Enemy;

                ShowHeroInventory();
                ShowEnemyInventory();

                _item1 = _itemFactory.GenerateMerchantItems();
                
                picItem1.Image = _item1.Image;
                tipMerchantItem1Pic.SetToolTip(picItem1, GetToolTipMessage(_item1));
                lblItem1Name.Text = "Item 1";

                _item2 = _itemFactory.GenerateMerchantItems();
                
                picItem2.Image = _item2.Image;
                tipMerchantItem2Pic.SetToolTip(picItem2, GetToolTipMessage(_item2));
                lblItem2Name.Text = "Item 2";

                _item3 = _itemFactory.GenerateMerchantItems();
                
                picItem3.Image = _item3.Image;
                tipMerchantItem3Pic.SetToolTip(picItem3, GetToolTipMessage(_item3));
                lblItem3Name.Text = "Item 3";
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = lstHeroInventory.SelectedItem as Item;
                if (selected != null)
                {
                    Item removed = _hero.Equipped.Unequip(selected.Slot);
                    if (removed != null)
                    {
                        _hero.Bag.Add(removed);
                    }

                    _hero.Bag.RemoveById(selected.Id);
                    _hero.Equipped.Equip(selected.Slot, selected);
                    ShowHeroInventory();
                }
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            var selected = lstHeroInventory.SelectedItem as Item;
            if (selected != null)
            {
                _hero.Bag.RemoveById(selected.Id);
                _currentGame.Gold += selected.GoldValue;
                ShowHeroInventory();
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            var selected = lstHeroInventory.SelectedItem as Item;
            if (selected != null)
            {
                _hero.Bag.RemoveById(selected.Id);
                _enemy.Bag.Add(selected);
                ShowHeroInventory();
                ShowEnemyInventory();
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            var selected = lstHeroInventory.SelectedItem as Item;
            if(selected != null)
            {
                Potion p = selected as Potion;
                if (p != null)
                {
                    int healing = p.HealValue;
                    _hero.Heal(healing);
                    _hero.Bag.RemoveById(selected.Id);
                    ShowHeroInventory();
                }
            }
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            //foreach(Item j in _hero.Bag)
            //{
            //    if (j is Junk)
            //    {
            //        _hero.Bag.RemoveById(j.Id);
            //        _currentGame.Gold += j.GoldValue;
            //    }
            //}
            for(int z = _hero.Bag.Count - 1; z >= 0; --z)
            {
                Junk j = _hero.Bag[z] as Junk;
                if (j != null)
                {
                    _hero.Bag.RemoveAt(z);
                    _currentGame.Gold += j.GoldValue;
                }
            }
            ShowHeroInventory();
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            _hero.Bag.SortByName();
            ShowHeroInventory();
        }

        private void btnSortByWeight_Click(object sender, EventArgs e)
        {
            _hero.Bag.SortByWeight();
            ShowHeroInventory();
        }

        private void btnSortByAttack_Click(object sender, EventArgs e)
        {
            _hero.Bag.SortByAttack();
            ShowHeroInventory();
        }

        private void btnSortByDefense_Click(object sender, EventArgs e)
        {
            _hero.Bag.SortByDefense();
            ShowHeroInventory();
        }

        private void btnSortByGold_Click(object sender, EventArgs e)
        {
            _hero.Bag.SortByGoldValue();
            ShowHeroInventory();
        }

        private void picItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _hero.Bag.Add(_item1);
                _currentGame.Gold -= _item1.GoldValue;
                ShowHeroInventory();
                picItem1.Image = Properties.Resources.questionMark;
                lblItem1Name.Text = "???";
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void picItem2_Click(object sender, EventArgs e)
        {
            try
            {
                _hero.Bag.Add(_item2);
                _currentGame.Gold -= _item2.GoldValue;
                ShowHeroInventory();
                picItem2.Image = Properties.Resources.questionMark;
                lblItem2Name.Text = "???";
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void picItem3_Click(object sender, EventArgs e)
        {
            try
            {
                _hero.Bag.Add(_item3);
                _currentGame.Gold -= _item3.GoldValue;
                ShowHeroInventory();
                picItem3.Image = Properties.Resources.questionMark;
                lblItem3Name.Text = "???";
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lstEnemyInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = lstEnemyInventory.SelectedItem as Item;
            if(selected == null)
            {
                picEnemySelectedItem.Image = Properties.Resources.questionMark;
                tipEnemyInventorySelectedItem.SetToolTip(picEnemySelectedItem, "???");
            }
            else
            {
                picEnemySelectedItem.Image = selected.Image;
                tipEnemyInventorySelectedItem.SetToolTip(picEnemySelectedItem, GetToolTipMessage(selected));
                lblSelectedItemDetails.Text = 
                    $"({selected.Slot.ToString()})";
            }
        }

        private void lstHeroInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = lstHeroInventory.SelectedItem as Item;
            if (selected == null)
            {
                picHeroSelectedItem.Image = Properties.Resources.questionMark;
                tipHeroInventorySelectedItem.SetToolTip(picEnemySelectedItem, "???");
            }
            else
            {
                picHeroSelectedItem.Image = selected.Image;
                tipHeroInventorySelectedItem.SetToolTip(picHeroSelectedItem, GetToolTipMessage(selected));
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = lstEnemyInventory.SelectedItem as Item;
                if (selected != null)
                {
                    _enemy.Bag.RemoveById(selected.Id);
                    _hero.Bag.Add(selected);
                    ShowHeroInventory();
                    ShowEnemyInventory();
                }
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            int level = _currentGame.Level;
            if (level == 5 || level == 10 || level == 15)
            {
                string DOOMmessage =
                    "A magical box appears before you! " +
                    "A voice bellows in your head. It says... The power " +
                    "of the unicorn awaits you... or your DOOM... " +
                    "YES opens the box... NO throws away glory...";
                DialogResult DOOMresult = MessageBox.Show(
                    this,
                    DOOMmessage,
                    "DOOMbox",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (DOOMresult == DialogResult.Yes)
                {
                    if (_itemFactory.RollForDoomGear())
                    {
                        _hero.Helmet = _itemFactory.SpawnDoomHelmet();
                        _hero.Vest = _itemFactory.SpawnDoomVest();
                        _hero.Blade = _itemFactory.SpawnDoomBlade();
                        string DOOMblessing =
                            "You've been blessed by Alan the Unicorn! " +
                            "You are DOOM!!!";
                        DialogResult blessing = MessageBox.Show(
                            this,
                            DOOMblessing,
                            "DOOMblessingBox",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        _hero.DOOM();
                        string DOOMcurse =
                            "YOU\r\nARE\r\nDOOMED!";
                        DialogResult blessing = MessageBox.Show(
                            this,
                            DOOMcurse,
                            "DOOMcurseBox",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Your mother would be so proud");
                }
            }
            else if (level == 20)
            {
                _hero.Helmet = _itemFactory.SpawnDoomHelmet();
                _hero.Vest = _itemFactory.SpawnDoomVest();
                _hero.Blade = _itemFactory.SpawnDoomBlade();
                string DOOMblessing =
                            "You've been blessed by Alan the Unicorn! " +
                            "You are DOOM!!!";
                DialogResult blessing = MessageBox.Show(
                    this,
                    DOOMblessing,
                    "DOOMblessingBox",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            _roguelite.SwitchScreens(ScreenId.COMBAT);
            if (_roguelite.SaveGamePath != null)
            {
                Game.SaveGame(_roguelite.SaveGamePath, _roguelite.CurrentGame);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dLog = new SaveFileDialog();
            dLog.Filter = "Save Game (*.sav)|*.sav";
            if (dLog.ShowDialog() == DialogResult.OK)
            {
                string path = dLog.FileName;
                _roguelite.SaveGamePath = path;
                Game.SaveGame(path, _roguelite.CurrentGame);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dLog = new OpenFileDialog();
            dLog.Filter = "Save Game (*.sav)|*.sav";
            if(dLog.ShowDialog() == DialogResult.OK)
            {
                string path = dLog.FileName;
                _roguelite.SaveGamePath = path;
                _roguelite.CurrentGame = Game.LoadGame(path);
                _roguelite.SwitchScreens(ScreenId.INVENTORY);
            }
        }

        public void ShowHeroInventory()
        {
            lstHeroInventory.Items.Clear();
            foreach(Item i in _hero.Bag)
            {
                lstHeroInventory.Items.Add(i);
            }
            if (lstHeroInventory.Items.Count > 0)
            {
                lstHeroInventory.SelectedIndex = 0;
            }

            lblHeroName.Text = _hero.Name;
            lblHeroHp.Text = $"HP: {_hero.Hp}";
            lblHeroGold.Text = $"{_currentGame.Gold} Gold";
            lblHeroInventoryItemCount.Text = $"{_hero.Bag.Count}/20";
            lblHeroInventoryCurrentWeight.Text = $"{_hero.Bag.TotalWeight:0.0} lbs";

            if(_hero.Helmet == null)
            {
                picHeroHelmet.Image = Properties.Resources.questionMark;
                tipHeroHelmetPic.SetToolTip(picHeroHelmet, "???");
                lblHeroHelmetName.Text = "NO HELMET";
            }
            else
            {
                picHeroHelmet.Image = _hero.Helmet.Image;
                tipHeroHelmetPic.SetToolTip(picHeroHelmet, _hero.Helmet.Name);
                lblHeroHelmetName.Text = $"(+{_hero.Helmet.Def}) ({_hero.Helmet.GoldValue} Gold)";
            }
            
            if(_hero.Vest == null)
            {
                picHeroVest.Image = Properties.Resources.questionMark;
                tipHeroVestPic.SetToolTip(picHeroVest, "???");
                lblHeroVestName.Text = "NO VEST";
            }
            else
            {
                picHeroVest.Image = _hero.Vest.Image;
                tipHeroVestPic.SetToolTip(picHeroVest, _hero.Vest.Name);
                lblHeroVestName.Text = $"(+{_hero.Vest.Def}) ({_hero.Vest.GoldValue} Gold)";
            }
            
            if(_hero.Blade == null)
            {
                picHeroWeapon.Image = Properties.Resources.questionMark;
                tipHeroWeaponPic.SetToolTip(picHeroWeapon, "???");
                lblHeroWeaponName.Text = "NO WEAPON";
            }
            else
            {
                picHeroWeapon.Image = _hero.Blade.Image;
                tipHeroWeaponPic.SetToolTip(picHeroWeapon, _hero.Blade.Name);
                lblHeroWeaponName.Text = $"(+{_hero.Blade.ATK}) ({_hero.Blade.GoldValue} Gold)";
            }
            
            if(_hero.Potion == null)
            {
                picHeroPotion.Image = Properties.Resources.questionMark;
                tipHeroPotionPic.SetToolTip(picHeroPotion, "???");
                lblHeroPotionName.Text = "NO POTION";
            }
            else
            {
                picHeroPotion.Image = _hero.Potion.Image;
                tipHeroPotionPic.SetToolTip(picHeroPotion, _hero.Potion.Name);
                lblHeroPotionName.Text = $"(+{_hero.Potion.HealValue}) ({_hero.Potion.GoldValue} Gold)";
            }
            
        }

        public void ShowEnemyInventory()
        {
            lblEnemyName.Text = $"{_enemy.Name} (DEAD)";
            lstEnemyInventory.Items.Clear();
            foreach (Item i in _enemy.Bag)
            {
                lstEnemyInventory.Items.Add(i);
            }
            if (lstEnemyInventory.Items.Count > 0)
            {
                lstEnemyInventory.SelectedIndex = 0;
            }
            else
            {
                picEnemySelectedItem.Image = Properties.Resources.questionMark;
            }
        }
        
        public string GetToolTipMessage(Item item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(item.Name);

            Armor a = item as Armor;
            if(a != null)
            {
                sb.AppendLine($"(+{a.Def} Def)");
            }

            Weapon b = item as Weapon;
            if (b != null)
            {
                sb.AppendLine($"(+{b.ATK} Atk)");
            }

            Potion c = item as Potion;
            if (c != null)
            {
                sb.AppendLine($"(+{c.HealValue} Heals)");

            }
            sb.AppendLine($"{item.GoldValue} GP");
            sb.AppendLine($"{item.Weight} lbs");

            return sb.ToString();
        }

        private void picHeroHelmet_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hero.Helmet != null)
                {
                    Item removedHelmet = _hero.Equipped.Unequip(InventorySlotId.HELMET);
                    _hero.Bag.Add(removedHelmet);
                    ShowHeroInventory();
                }
            }
            catch(BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void picHeroVest_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hero.Vest != null)
                {
                    Item removedVest = _hero.Equipped.Unequip(InventorySlotId.VEST);
                    _hero.Bag.Add(removedVest);
                    ShowHeroInventory();
                }
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void picHeroWeapon_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hero.Blade != null)
                {
                    Item removedWeapon = _hero.Equipped.Unequip(InventorySlotId.WEAPON);
                    _hero.Bag.Add(removedWeapon);
                    ShowHeroInventory();
                }
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void picHeroPotion_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hero.Potion != null)
                {
                    Item removedPotion = _hero.Equipped.Unequip(InventorySlotId.POTION);
                    _hero.Bag.Add(removedPotion);
                    ShowHeroInventory();
                }
            }
            catch (BagFullException ex)
            {
                DialogResult BagFull = MessageBox.Show(
                    this,
                    ex.Message,
                    "Bag is Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
