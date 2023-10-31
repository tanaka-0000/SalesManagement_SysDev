using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class loginTouroku : Form
    {
        //データベース商品カテゴリテーブルアクセス用クラスのインスタンス化
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

        //パスワードハッシュ用クラスのインスタンス化
        passwordHash passwordHash = new passwordHash();


        //他のフォームから変数の内容を共有できるように宣言
        internal static string loginID = "";
        internal static string loginPass = "";



        public loginTouroku()
        {
            InitializeComponent();
        }

        private void textBoxnewloginID_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTouroku_Load(object sender, EventArgs e)
        {

        }

        private void buttonnewLogin_Click(object sender, EventArgs e)
        {
            string loginID = textBoxnewloginID.Text;
            string loginPass = textBoxnewpass.Text;
            bool flg;
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel);

            if (loginID.Trim() == "" || loginID == null || loginPass.Trim() == "" || loginPass == null)
            {
                //ID・PW未入力メッセージ
                MessageBox.Show("IDまたは、パスワードを入力してください。");
                return;
            }
            try
            {
                var pw = passwordHash.CreatePasswordHash(textBoxnewpass.Text.Trim());

                int loginIDs = int.Parse(textBoxnewloginID.Text.Trim());

                //ユーザID・PWチェック
                var context = new SalesManagement_DevContext();
                //ユーザID・PWが存在するか
                flg = context.M_Employees.Any(x => x.EmID == loginIDs && x.EmPassword == loginPass);
                if (flg == true)
                {
                    //SQL文
                    //「M_Employees」テーブル参照
                    //社員ID・パスワードを部分一致
                    //部分一致が未入力の場合、全件表示

                    var tb = from t1 in context.M_Employees
                             from t2 in context.M_Employees
                             where t1.EmID == loginIDs && t2.EmPassword == pw
                             select new
                             {
                                 t1.EmID,
                                 t2.EmPassword,

                             };
                    foreach (var p in tb)
                    {
                        loginTouroku.loginID = loginID.ToString();
                        loginTouroku.loginPass = p.EmPassword;

                    }

                    context.Dispose();
                    this.Close();

                }

                else if (result == DialogResult.Cancel)
                {

                    // パスワード情報の登録
                    flg = EmployeeDataAccess.AddPassData(regPass);
                    if (flg == true)
                    {
                        MessageBox.Show("パスワードを登録しました。");
                    }
                    else
                    {
                        MessageBox.Show("パスワードの登録に失敗しました。");
                    }

                    textBoxnewpass.Focus();
                    return;
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxnewpass_TextChanged(object sender, EventArgs e)
        {
            //textBoxnewpass.Textに入力された文字を「*」で表示されるようにする
            textBoxnewpass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
