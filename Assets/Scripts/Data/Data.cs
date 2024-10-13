namespace Data {
    public class Texts {
        public const string Heart = "❤";
    }

    public class Directions {
        public const string Horisontal = "Horizontal";
        public const string Vertical = "Vertical";
    }

    public class Tags {
        public const string Enemy = "Enemy";
        public const string Player = "Player";
        public const string Health = "Health";
    }

    public class Events {
        public delegate void OnHealthChanged(int health);
    }
}