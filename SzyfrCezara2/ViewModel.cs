using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using StyleMVVM.DependencyInjection;
using StyleMVVM.Messenger;
using StyleMVVM.View;
using StyleMVVM.ViewModel;

namespace SzyfrCezara2
{
    public class ViewModel : PageViewModel
    {
        private string plainText;
        private string cipherText;

        public string PlainText
        {
            get
            {
                return plainText;
            }

            set
            {
                plainText = value;
                OnPropertyChanged();
            }
        }

        public string CipherText
        {
            get
            {
                return cipherText;
            }

            set
            {
                cipherText = value;
                OnPropertyChanged();
            }
        }

        public void Encrypt(string message, int shift = 3)
        {
            cipherText = ShiftMessage(message, shift);
            OnPropertyChanged("CipherText");
        }

        public void Decrypt(string message, int shift = 3)
        {
            plainText = ShiftMessage(message, 26 - shift);
            OnPropertyChanged("PlainText");
        }

        private string ShiftMessage(string message, int shift = 3)
        {
            if (message == null)
            {
                return string.Empty;
            }

            var result = string.Empty;

            foreach (char c in message)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    result += (char)(((c - 'A' + shift) % 26) + 'A');
                }
                else if (c >= 'a' && c <= 'z')
                {
                    result += (char)(((c - 'a' + shift) % 26) + 'a');
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
