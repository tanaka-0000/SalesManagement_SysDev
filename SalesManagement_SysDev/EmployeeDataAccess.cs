using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    internal class EmployeeDataAccess
    {
        public bool CheckCategoryCDExistence(int loginID)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //社員IDで一致するデータが存在するか
                flg = context.M_Employees.Any(x => x.EmID == loginID);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }


        public bool CheckUserIDExistenceCount(string loginPass)
        {
            bool flg = false;
            try
            {
                var context = new SalesManagement_DevContext();
                //ログインユーザIDで一致するデータが存在するか
                flg = context.M_Employees.Any(x => x.EmPassword == loginPass);
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flg;
        }

        ///////////////////////////////
        //メソッド名：AddPassData()
        //引　数   ：社員データ
        //戻り値   ：True or False
        //機　能   ：社員パスワードデータの登録
        //          ：登録成功の場合True
        //          ：登録失敗の場合False
        ///////////////////////////////

        public bool AddPassData(M_Employee regPass)
        {
            try
            {
                var context = new SalesManagement_DevContext();
                context.M_Employees.Add(regPass);
                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
