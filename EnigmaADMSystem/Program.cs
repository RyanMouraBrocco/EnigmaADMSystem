using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass;

namespace EnigmaADMSystem
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        // lista para cadastro de conteudo e resumo
        public static List<ConteudoTexto> _contText = new List<ConteudoTexto>();
        public static List<Resumo> _resum = new List<Resumo>();
        public static bool Salvar = false;

        // Exercicio que está sendo editado
        public static Exercicio _ex = new Exercicio();
        public static Questao _qu = new Questao();

        // Logoff do Sistema 
        public static bool Logoff = false;
        public static Form Login;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}
