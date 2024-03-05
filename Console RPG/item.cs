using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
     abstract class Item
    {
        public string name;
        public string description;
        public int shopPrice;
        public int sellPrice;

        public Item(string name, string description, int shopPrice, int sellPrice)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.sellPrice = sellPrice;
        }

        public abstract void Use(Entity user, Entity target);
    }

    class HealthPotionItem : Item 
    {

        public int healAmount;

        public HealthPotionItem(string name, string description, int shopPrice, int sellPrice, int healAmount) : base(name, description,shopPrice,sellPrice)
        {
            this.healAmount = healAmount;
            
        }
        public override void Use(Entity user, Entity target)
        {
            target.currentHP += this.healAmount;
            Console.WriteLine(target.name + "healed");
        }
    }
    class swordItem : Item
    {
        
    }
}
