using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_sistema.Control
{
    public static class ControlFormulario
    {
        public static void alterarFormulario(Form formulario, Panel painel)
        {
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            painel.Controls.Clear();
            painel.Controls.Add(formulario);
            formulario.Show();
        }

    }
}
