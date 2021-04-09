namespace gate_prjct
{
    public class CKBudha: AKerajaan
    {
        private static int totalData = 0;
        private static string[] kArray = new string[100];
        private string fileName = "kerajaanBudha";
        private static string workfile;
        public void setData(){
            workspace work = new workspace();
            workfile = work.workspaces+fileName+".txt";
            setArray(kArray, workfile);
            showArray(kArray, totalData);
        }
        public new void setArray(string[] kArray, string workspace){
            base.setArray(kArray, workspace);
        }
        public new void showArray(string[] kArray, int count){
            base.showArray(kArray, count);
        }
        public string rWorkfile(){
            return workfile;
        }
    }
}