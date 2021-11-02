using System.Windows.Forms;

namespace LunaEditor.Controls
{
    public sealed class MainMenuStrip : MenuStrip
    {
        public const string NAME = "MainMenuStrip";
        public MainMenuStrip()
        {
            Name = NAME;
            Dock = DockStyle.Top;
            
            FileDropDownMenu();
            EditDropDownMenu();
            FormatDropDownMenu();
            ViewDropDownMenu();
        }

        public void FileDropDownMenu()
        {
            var fileDropDownMenu = new ToolStripMenuItem("Fichier");

            var newMenu = new ToolStripMenuItem("Nouveau", null, null, Keys.Control | Keys.N);
            var openMenu = new ToolStripMenuItem("Ouvrir...", null, null, Keys.Control | Keys.O);
            var saveMenu = new ToolStripMenuItem("Enregister", null, null, Keys.Control | Keys.S);
            var saveAsMenu = new ToolStripMenuItem("Enregistrer sous...", null, null, Keys.Control | Keys.Shift | Keys.N);
            var quitMenu = new ToolStripMenuItem("Quitter", null, null, Keys.Alt | Keys.F4);

            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] {newMenu, openMenu, saveMenu, saveAsMenu, quitMenu});

            Items.Add(fileDropDownMenu);
        }

        public void EditDropDownMenu()
        {
            var editDropDownMenu = new ToolStripMenuItem("Edition");

            var cancelMenu = new ToolStripMenuItem("Annuler", null, null, Keys.Control | Keys.Z);
            var restoreMenu = new ToolStripMenuItem("Restaurer", null, null, Keys.Control | Keys.Y);

            editDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] {cancelMenu, restoreMenu});

            Items.Add(editDropDownMenu);
        }

        public void FormatDropDownMenu()
        {
            var formatDropDownMenu = new ToolStripMenuItem("Format");

            var fontMenu = new ToolStripMenuItem("Police...");

            formatDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { fontMenu });

            Items.Add(formatDropDownMenu);
        }

        public void ViewDropDownMenu()
        {
            var viewDropDownMenu = new ToolStripMenuItem("Affichage");

            var alwaysOnTopMenu = new ToolStripMenuItem("Toujours devant");
            
            var zoomDropDownMenu = new ToolStripMenuItem("Zoom");
            
            var zoomInMenu = new ToolStripMenuItem("Zoom avant", null, null, Keys.Control | Keys.Add);
            var zoomOutMenu = new ToolStripMenuItem("Zoom arrière", null, null, Keys.Control | Keys.Subtract);
            var zoomResetMenu = new ToolStripMenuItem("Restaurer le zoom par défaut", null, null, Keys.Control | Keys.Divide);

            zoomInMenu.ShortcutKeyDisplayString = "Ctrl+Num +";
            zoomOutMenu.ShortcutKeyDisplayString = "Ctrl+Num -";
            zoomResetMenu.ShortcutKeyDisplayString = "Ctrl+Num /";

            zoomDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { zoomInMenu, zoomOutMenu, zoomResetMenu });
            
            viewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopMenu, zoomDropDownMenu });

            Items.Add(viewDropDownMenu);
        }
    }
}