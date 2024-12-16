using System;

namespace KeyotiRapidSpell
{
    // Core RapidSpell functionality
    using Keyoti.RapidSpell;
    public class SpellCheckerExample {
        private readonly RapidSpellAsYouType _spellChecker = new RapidSpellAsYouType();
        public void ConfigureSpellChecker() {
            _spellChecker.CheckAsYouType = true;
            _spellChecker.ShowDialog = true;
        }
    }

    // Dictionary management
    using Keyoti.RapidSpell.Dictionaries;
    public class DictionaryExample {
        private readonly WordDictionary _dictionary = new WordDictionary();
        public void LoadDictionary() {
            _dictionary.LoadDictionary("en-US.dic");
            _dictionary.AddWord("CustomWord");
        }
    }

    // Spell checking options
    using Keyoti.RapidSpell.SpellChecking;
    public class SpellCheckOptionsExample {
        private readonly SpellCheckOptions _options = new SpellCheckOptions();
        public void ConfigureOptions() {
            _options.IgnoreAllCaps = true;
            _options.IgnoreNumbers = true;
            _options.SuggestionsMethod = SuggestionsMethodEnum.PhoneticAndTypo;
        }
    }

    // Custom dictionary handling
    using Keyoti.RapidSpell.UserDictionaries;
    public class UserDictionaryExample {
        private readonly UserDictionary _userDict = new UserDictionary();
        public void ManageUserDictionary() {
            _userDict.AddWord("CompanyName");
            _userDict.SaveDictionary("custom.dic");
        }
    }

    // Spell check events
    using Keyoti.RapidSpell.Events;
    public class SpellCheckEventsExample {
        private readonly RapidSpellChecker _checker = new RapidSpellChecker();
        public void SetupEvents() {
            _checker.MisspelledWord += (sender, args) => {
                Console.WriteLine($"Misspelled word: {args.Word}");
            };
        }
    }

    // Language support
    using Keyoti.RapidSpell.Languages;
    public class LanguageExample {
        private readonly LanguageConfig _langConfig = new LanguageConfig();
        public void ConfigureLanguage() {
            _langConfig.SetLanguage(LanguageType.English);
            _langConfig.LoadAlternateSpellings();
        }
    }

    // Text processing
    using Keyoti.RapidSpell.TextProcessing;
    public class TextProcessExample {
        private readonly TextProcessor _processor = new TextProcessor();
        public string[] ProcessText(string text) {
            return _processor.SplitIntoWords(text);
        }
    }

    // Spell check dialog
    using Keyoti.RapidSpell.Dialog;
    public class SpellDialogExample {
        private readonly SpellCheckDialog _dialog = new SpellCheckDialog();
        public void ShowSpellDialog(string text) {
            _dialog.Text = text;
            _dialog.ShowDialog();
        }
    }

    // Custom suggestions
    using Keyoti.RapidSpell.Suggestions;
    public class SuggestionsExample {
        private readonly SuggestionGenerator _generator = new SuggestionGenerator();
        public string[] GetSuggestions(string word) {
            return _generator.GetSuggestions(word, 5);
        }
    }

    // Configuration settings
    using Keyoti.RapidSpell.Configuration;
    public class ConfigurationExample {
        private readonly SpellCheckerConfig _config = new SpellCheckerConfig();
        public void SetConfiguration() {
            _config.MaxSuggestions = 10;
            _config.CaseSensitive = false;
        }
    }
}