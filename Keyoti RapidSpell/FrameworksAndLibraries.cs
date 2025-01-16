using Keyoti.RapidSpell;
using Keyoti.RapidSpell.Dictionary;
using Keyoti.RapidSpell.Phonetics;
using Keyoti.RapidSpell.Suggestions;
using Keyoti.RapidSpell.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace KeyotiRapidSpell
{
    public class BasicSpellCheckExample
    {
        public void BasicSpellCheck()
        {
            var spellChecker = new SpellChecker();
            bool isCorrect = spellChecker.TestWord("hello");
            bool isIncorrect = spellChecker.TestWord("helo");
        }
    }

    public class CustomDictionaryExample 
    {
        public void CustomDictionary()
        {
            var spellChecker = new SpellChecker();
            spellChecker.Dictionary.Add("customword");
            bool exists = spellChecker.TestWord("customword");
        }
    }

    public class PhoneticExample
    {
        public void PhoneticMatching()
        {
            var spellChecker = new SpellChecker();
            spellChecker.PhoneticMatching = true;
            var suggestions = spellChecker.Suggest("fone");
            bool hasPhoneSuggestion = suggestions.Contains("phone");
        }
    }

    public class SuggestionDistanceExample
    {
        public void SuggestionDistance()
        {
            var spellChecker = new SpellChecker();
            spellChecker.SuggestionDistance = 2;
            var suggestions = spellChecker.Suggest("recieve");
            bool hasCorrectSuggestion = suggestions.Contains("receive");
        }
    }

    public class LanguageExample
    {
        public void LanguageSupport()
        {
            var spellChecker = new SpellChecker();
            spellChecker.LoadDictionary(Language.French);
            bool isFrenchWordCorrect = spellChecker.TestWord("bonjour");
        }
    }

    public class IgnoreNumbersExample
    {
        public void IgnoreNumbers()
        {
            var spellChecker = new SpellChecker();
            spellChecker.IgnoreNumbers = true;
            bool isNumberIgnored = spellChecker.TestWord("123");
        }
    }

    public class CaseSensitivityExample
    {
        public void CaseSensitivity()
        {
            var spellChecker = new SpellChecker();
            spellChecker.CaseSensitive = true;
            bool isCapitalCorrect = spellChecker.TestWord("Hello");
            bool isLowercaseIncorrect = spellChecker.TestWord("hello");
        }
    }

    public class CustomSuggestionExample
    {
        public void CustomSuggestions()
        {
            var spellChecker = new SpellChecker();
            spellChecker.SuggestionProvider = new CustomSuggestionProvider();
            var suggestions = spellChecker.Suggest("tst");
            bool hasCustomSuggestion = suggestions.Contains("test");
        }
    }

    public class DictionaryLoadingExample
    {
        public void LoadDictionary()
        {
            var spellChecker = new SpellChecker();
            spellChecker.LoadDictionaryFromFile("custom.dic");
            int wordCount = spellChecker.Dictionary.Count;
        }
    }

    public class WordReplacementExample
    {
        public void ReplaceWord()
        {
            var spellChecker = new SpellChecker();
            string text = "teh quick brown fox";
            string corrected = spellChecker.ReplaceWord(text, "teh", "the");
        }
    }

    public class IgnoreWordsExample
    {
        public void IgnoreWords()
        {
            var spellChecker = new SpellChecker();
            spellChecker.IgnoreList.Add("xyz");
            bool isIgnoredWordAccepted = spellChecker.TestWord("xyz");
        }
    }

    public class TextStatsExample
    {
        public void TextStatistics()
        {
            var spellChecker = new SpellChecker();
            var stats = spellChecker.GetTextStatistics("Hello world");
            int wordCount = stats.WordCount;
        }
    }

    public class BatchProcessingExample
    {
        public void BatchProcess()
        {
            var spellChecker = new SpellChecker();
            string[] words = new[] { "hello", "wrld" };
            bool[] results = spellChecker.TestWords(words);
        }
    }

    public class DictionaryExportExample
    {
        public void ExportDictionary()
        {
            var spellChecker = new SpellChecker();
            spellChecker.Dictionary.Add("customterm");
            spellChecker.Dictionary.SaveToFile("export.dic");
        }
    }

    public class MultipleDictionaryExample
    {
        public void MultipleDictionaries()
        {
            var spellChecker = new SpellChecker();
            spellChecker.LoadDictionary(Language.English);
            spellChecker.LoadDictionary(Language.Spanish);
            bool isEnglishWordCorrect = spellChecker.TestWord("hello");
            bool isSpanishWordCorrect = spellChecker.TestWord("hola");
        }
    }
}
