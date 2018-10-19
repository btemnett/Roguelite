using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EX1
{
    [Serializable]
    public class Game
    {
        protected int _level;
        protected int _gold;
        protected Character _player;
        protected Character _enemy;

        public Game()
        {
            _level = 0;
            _gold = 50;
        }
        public static Game LoadGame(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var f = new BinaryFormatter();
                Game g = (Game)f.Deserialize(stream);
                return g;
            }
        }
        public static void SaveGame(string path, Game g)
        {
            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var f = new BinaryFormatter();
                f.Serialize(stream, g);
                stream.Flush();
            }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        public Character Player
        {
            get { return _player; }
            set { _player = value; }
        }
        public Character Enemy
        {
            get { return _enemy; }
            set { _enemy = value; }
        }
    }
}
