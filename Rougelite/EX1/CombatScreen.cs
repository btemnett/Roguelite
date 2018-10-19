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
    public partial class CombatScreen : UserControl
    {
        private Random _rand;
        private CharacterFactory _characterFactory;
        private ItemFactory _itemFactory;
        private RogueliteForm _roguelite;

        private Game _game;
        private Character _hero;
        private Character _enemy;


        string[] _quips = new string[]
        {
            "Dude... He is dead... Hit Next Level or quit...",
            "How cute... you like playing with immobile ragdolls...",
            "Wow... just when I thought humanity could sink no lower\n\n" +
            "I see you whacking away at a corpse...",
            "OMG WOULD YOU JUST HIT LOOT ALREADY",
            "Bro... you need Jesus",
            "I can't watch. Why are you hitting it??? IT'S DEAD!!!"
        };

        public CombatScreen()
        {
            InitializeComponent();
            
            // Initialize variables
            _rand = new Random();
            _characterFactory = new CharacterFactory();
            _itemFactory = new ItemFactory();
            
        }
        public RogueliteForm Roguelite
        {
            get { return _roguelite; }
            set { _roguelite = value; }
        }

        private void CombatScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && _roguelite != null)
            {
                _game = _roguelite.CurrentGame;
                ++_game.Level;
                _hero = _game.Player;
                _enemy = _characterFactory.SpawnEnemy(_game.Level);
                _game.Enemy = _enemy;

                lblGameOver.Text = string.Format(
                    "{0} has barred your passage",
                    _enemy.Name
                );
                lblHeroName.ForeColor = Color.White;
                lblHeroDEF.ForeColor = Color.White;
                lblHeroHP.ForeColor = Color.White;
                lblHeroATK.ForeColor = Color.White;

                lblEnemyName.ForeColor = Color.White;
                lblEnemyHP.ForeColor = Color.White;
                lblEnemyATK.ForeColor = Color.White;
                lblEnemyDEF.ForeColor = Color.White;

                lblRound.Text = $"{_game.Level}/50";
                btnHeal.Visible = !_hero.IsDOOMed;
                ShowFighters();
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (_hero.IsDead)
            {
                lblGameOver.Text = "Dude... YOU ARE DEAD!\n\n" +
                    "That's what GAME OVER meant... Click Loot";
                return;
            }
            if (_enemy.IsDead)
            {
                lblGameOver.Text = _quips[_rand.Next(0, _quips.Length)];
                return;
            }

            int heroATKDamage = CalcAttackDamage(_hero.TotalAtk, _enemy.TotalDef);
            int enemyATKDamage = 0;
            _enemy.ApplyDamage(heroATKDamage);

            if (!_enemy.IsDead)
            {
                enemyATKDamage = CalcAttackDamage(_enemy.TotalAtk, _hero.TotalDef);
                _hero.ApplyDamage(enemyATKDamage);
            }

            ShowDamageDealt(heroATKDamage, enemyATKDamage);
            ShowFighters();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (_enemy.IsDead)
            {
                lblGameOver.Text = string.Format(
                   "{0}\n\n{1}",
                   "Dude... He is dead... Hit Loot or quit...",
                   "But nice try... NO HEALING APPLIED!"
                   );
            }
            else if (_hero.IsDead)
            {
                lblGameOver.Text = "Dude... YOU ARE DEAD!\n\n" +
                    "That's what GAME OVER meant... Click Loot";
            }
            else if(_hero.Potion != null)
            {
                int healing = _hero.Potion.HealValue;
                _hero.Heal(healing);
                lblGameOver.Text = $"Used {_hero.Potion.Name}, Healed {healing} HP";
                _hero.Equipped.Unequip(InventorySlotId.POTION);
                
                ShowFighters();
            }
            else
            {
                lblGameOver.Text = "NO POTION EQUIPPED";
            }
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            if (_hero.IsDead)
            {
                lblGameOver.Text = "Dude... YOU ARE DEAD!\n\n" +
                    "That's what GAME OVER meant... Click Loot";
                return;
            }
            if (_enemy.IsDead)
            {
                lblGameOver.Text = _quips[_rand.Next(0, _quips.Length)];
                return;
            }

            int heroATKDamage = CalcGuardDamage(_hero.TotalAtk, _enemy.TotalDef);
            int enemyATKDamage = 0;
            _enemy.ApplyDamage(heroATKDamage);

            if (!_enemy.IsDead)
            {
                enemyATKDamage = CalcGuardDamage(_enemy.TotalAtk, _hero.TotalDef);
                _hero.ApplyDamage(enemyATKDamage);
            }

            ShowDamageDealt(heroATKDamage, enemyATKDamage);
            ShowFighters();
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            if (_hero.IsDead)
            {
                // switch to Game over screen
                _roguelite.SwitchScreens(ScreenId.GAME_OVER);
            }
            else if (_enemy.IsDead)
            {
                //switchtoInventoryScreen
                if(_enemy.Helmet != null && !_enemy.Helmet.IsNatural)
                {
                    Item removedHelmet = _enemy.Equipped.Unequip(InventorySlotId.HELMET);
                    _enemy.Bag.Add(removedHelmet);
                }
                if(_enemy.Vest != null && !_enemy.Vest.IsNatural)
                {
                    Item removedVest = _enemy.Equipped.Unequip(InventorySlotId.VEST);
                    _enemy.Bag.Add(removedVest);
                }
                if(_enemy.Blade != null && !_enemy.Blade.IsNatural)
                {
                    Item removedWeapon = _enemy.Equipped.Unequip(InventorySlotId.WEAPON);
                    _enemy.Bag.Add(removedWeapon);
                }
                //if(_enemy.Potion != null && !_enemy.Potion.IsNatural)
                //{
                //    Item removedPotion = _enemy.Equipped.Unequip(InventorySlotId.POTION);
                //    _enemy.Bag.Add(removedPotion);
                //}
                _roguelite.SwitchScreens(ScreenId.INVENTORY);
            }
            else
            {
                lblGameOver.Text = string.Format(
                    "{0} has barred your passage",
                    _enemy.Name
                );
            }
        }

        public void ShowFighters()
        {
            // Show hero
            lblHeroName.Text = string.Format("Hero Name: {0}", _hero.Name);
            lblHeroHP.Text = string.Format("HP: {0}", _hero.Hp);
            lblHeroATK.Text = string.Format("ATK: {0}", _hero.TotalAtk);
            lblHeroDEF.Text = string.Format("DEF: {0}", _hero.TotalDef);

            if (_hero.Helmet == null)
            {
                lblHeroHelmetName.Text = "NO HELMET";
                lblHeroHelmetDef.Text = "Def: 0";
                picHeroHelmet.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblHeroHelmetName.Text = string.Format("{0}", _hero.Helmet.Name);
                lblHeroHelmetDef.Text = string.Format("Def: {0}", _hero.Helmet.Def);
                picHeroHelmet.Image = _hero.Helmet.Image;
            }

            if (_hero.Vest == null)
            {
                lblHeroVestName.Text = "NO VEST";
                lblHeroVestDef.Text = "Def: 0";
                picHeroVest.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblHeroVestName.Text = string.Format("{0}", _hero.Vest.Name);
                lblHeroVestDef.Text = string.Format("Def: {0}", _hero.Vest.Def);
                picHeroVest.Image = _hero.Vest.Image;
            }

            if (_hero.Blade == null)
            {
                lblHeroWeaponName.Text = "NO WEAPON";
                lblHeroWeaponAtk.Text = "Atk: 0";
                picHeroWeapon.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblHeroWeaponName.Text = string.Format("{0}", _hero.Blade.Name);
                lblHeroWeaponAtk.Text = string.Format("Atk: {0}", _hero.Blade.ATK);
                picHeroWeapon.Image = _hero.Blade.Image;
            }

            if(_hero.Potion == null)
            {
                lblHeroPotionName.Text = "NO POTION";
                lblHeroPotionHeals.Text = "Heals: 0";
                picHeroPotion.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblHeroPotionName.Text = string.Format("{0}", _hero.Potion.Name);
                lblHeroPotionHeals.Text = string.Format("Heals: {0}", _hero.Potion.HealValue);
                picHeroPotion.Image = _hero.Potion.Image;
            }

            // Show enemy
            lblEnemyName.Text = string.Format("Enemy Name: {0}", _enemy.Name);
            lblEnemyHP.Text = string.Format("HP: {0}", _enemy.Hp);
            lblEnemyATK.Text = string.Format("ATK: {0}", _enemy.TotalAtk);
            lblEnemyDEF.Text = string.Format("DEF: {0}", _enemy.TotalDef);

            if (_enemy.Helmet == null)
            {
                lblEnemyHelmetName.Text = "NO HELMET";
                lblEnemyHelmetDef.Text = "Def: 0";
                picEnemyHelmet.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblEnemyHelmetName.Text = string.Format("{0}", _enemy.Helmet.Name);
                lblEnemyHelmetDef.Text = string.Format("Def: {0}", _enemy.Helmet.Def);
                picEnemyHelmet.Image = _enemy.Helmet.Image;
            }

            if (_enemy.Vest == null)
            {
                lblEnemyVestName.Text = "NO VEST";
                lblEnemyVestDef.Text = "Def: 0";
                picEnemyVest.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblEnemyVestName.Text = string.Format("{0}", _enemy.Vest.Name);
                lblEnemyVestDef.Text = string.Format("Def: {0}", _enemy.Vest.Def);
                picEnemyVest.Image = _enemy.Vest.Image;
            }

            if (_enemy.Blade == null)
            {
                lblEnemyWeaponName.Text = "NO WEAPON";
                lblEnemyWeaponAtk.Text = "Atk: 0";
                picEnemyWeapon.Image = Properties.Resources.questionMark;
            }
            else
            {
                lblEnemyWeaponName.Text = string.Format("{0}", _enemy.Blade.Name);
                lblEnemyWeaponAtk.Text = string.Format("Atk: {0}", _enemy.Blade.ATK);
                picEnemyWeapon.Image = _enemy.Blade.Image;
            }

            //if (_enemy.Potion == null)
            //{
            //    lblEnemyPotionName.Text = "NO POTION";
            //    lblEnemyPotionHeals.Text = "Heals: 0";
            //    picEnemyPotion.Image = Properties.Resources.questionMark;
            //}
            //else
            //{
            //    lblEnemyPotionName.Text = string.Format("{0}", _enemy.Potion.Name);
            //    lblEnemyPotionHeals.Text = string.Format("Heals: {0}", _enemy.Potion.HealValue);
            //    picEnemyPotion.Image = _hero.Potion.Image;
            //}
        }

        private void ShowDamageDealt(int heroATKDamage, int enemyATKDamage)
        {
            if (_hero.IsDead)
            {
                lblGameOver.Text = "GAME OVER";
                lblHeroName.ForeColor = Color.Red;
                lblHeroHP.ForeColor = Color.Red;
                lblHeroATK.ForeColor = Color.Red;
                lblHeroDEF.ForeColor = Color.Red;
            }
            else if (enemyATKDamage == 0 && _enemy.IsDead)
            {
                lblGameOver.Text = string.Format(
                    "{0} hit {1}! {2} damage!\n\n{3} is DEAD!",
                    _hero.Name, _enemy.Name, heroATKDamage, _enemy.Name
                );
                lblEnemyName.ForeColor = Color.Red;
                lblEnemyHP.ForeColor = Color.Red;
                lblEnemyATK.ForeColor = Color.Red;
                lblEnemyDEF.ForeColor = Color.Red;
            }
            else
            {
                lblGameOver.Text = string.Format(
                   "{0} hit {1}! {2} damage!\n\n{3} hit {4}! {5} damage! ",
                   _hero.Name, _enemy.Name, heroATKDamage,
                   _enemy.Name, _hero.Name, enemyATKDamage
               );
            }
        }

        public int CalcAttackDamage(int atk, int def)
        {
            int atkDamage = -(atk - def + _rand.Next(0, 4));
            if (atkDamage >= 0)
            {
                atkDamage = -1;
            }
            return atkDamage;
        }

        public int CalcGuardDamage(int atk, int def)
        {
            int guardDamage = -((atk - def) / 2 + _rand.Next(0, 3));
            if (guardDamage >= 0)
            {
                guardDamage = -1;
            }
            return guardDamage;
        }
    }
}
