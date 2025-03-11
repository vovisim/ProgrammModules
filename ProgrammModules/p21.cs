using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class Morze
    {

        private string enctiptedText;
        private string decriptedText;
        private Dictionary<string, string> alphabet = new Dictionary<string, string>()
        {
            { "A", ".-"},
            { "B", "-..."},
            { "C", "-.-."},
            { "D", "-.."},
            { "E", "."},
            { "F", "..-."},
            { "G", "--."},
            { "H", "...."},
            { "I", ".."},
            { "J", ".---"},
            { "K", "-.-"},
            { "L", ".-.."},
            { "M", "--"},
            { "N", "-."},
            { "O", "---"},
            { "P", ".--."},
            { "Q", "--.-"},
            { "R", ".-."},
            { "S", "..."},
            { "T", "-"},
            { "U", "..-"},
            { "V", "...-"},
            { "W", ".--"},
            { "X", "-..-"},
            { "Y", "-.--"},
            { "Z", "--.."}
        };

        private Dictionary<string, string> rAlphabet = new Dictionary<string, string>()
        {
            { ".-", "A"},
            { "-...", "B"},
            { "-.-.", "C"},
            { "-..", "D"},
            { ".", "E"},
            { "..-.", "F"},
            { "--.", "G"},
            { "....", "H"},
            { "..", "I"},
            { ".---", "J"},
            { "-.-", "K"},
            { ".-..", "L"},
            { "--", "M"},
            { "-.", "N"},
            { "---", "O"},
            { ".--.", "P"},
            { "--.-", "Q"},
            { ".-.", "R"},
            { "...", "S"},
            { "-", "T"},
            { "..-", "U"},
            { "...-", "V"},
            { ".--", "W"},
            { "-..-", "X"},
            { "-.--", "Y"},
            { "--..", "Z"},
            { ".----", "1"},
            { "..---", "2"},
            { "...--", "3"},
            { "....-", "4"},
            { ".....", "5"},
            { "-....", "6"},
            { "--...", "7"},
            { "---..", "8"},
            { "----.", "9"},
            { "-----", "0"}
        };
        
   

        public string encripter(string text)
        {
            var encriptedText = "";
            foreach (var item in text)
            {
                encriptedText += this.alphabet[item.ToString().ToUpper()];
            }
            return encriptedText;

        }
        public string decripter(string text)
        {
            var decriptedText = "";
            foreach (var item in text)
            {
                decriptedText += this.rAlphabet[item.ToString().ToUpper()];
            }
            return decriptedText;

        }

    }
}
