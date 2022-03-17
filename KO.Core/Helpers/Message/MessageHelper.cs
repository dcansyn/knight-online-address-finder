using KO.Core.Consts;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace KO.Core.Helpers.Message
{
    public class MessageHelper
    {
        public static bool Send(string text, MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(text, App.ApplicationName, button, icon) == DialogResult.Yes;
        }

        public static string Input(string title, string message, string initialValue)
        {
            return Interaction.InputBox(message, title, initialValue);
        }
    }
}
