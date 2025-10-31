using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    // Buttonクラスを継承した
    // TestButtonクラスを作成してください。
    internal class TestButton : Button
    {
        public TestButton(Point position, Size size, string text)
        {
            // ボタンの位置を設定
            Location = position;
            // ボタンの大きさを設定
            Size = size;
            // ボタン内のテキストを設定
            Text = text;

            Click += ClickEvent;
        }


        // 自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("TestButtonないで設定");
        }
    }
}