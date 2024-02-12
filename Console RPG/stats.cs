namespace Console_RPG
{
    // struct are useful for storing simple plain data
    struct stats
    {
        public int Dexterity;
        public int Strength;
        public int Constitution;
        public int Wisdom;
        public int Intelligence;
        public int Charisma;

        public stats(int dexterity, int strength, int constitution, int wisdom, int intelligence, int charisma)
        {
            Dexterity = dexterity;
            Strength = strength;
            Constitution = constitution;
            Wisdom = wisdom;
            Intelligence = intelligence;
            Charisma = charisma;
        }
    }

}
