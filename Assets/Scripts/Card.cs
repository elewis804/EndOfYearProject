using System;

//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

namespace Uno_Interactions
{
    class Card
    {
        public string name;
        
        public string color;
        public string effect;
        public Card(string name, string color, string effect){
            this.name = name;
            
            this.color = color;
            this.effect = effect;
        }
    }
}
