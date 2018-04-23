using System.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace ZBobb {
    [UserRepositoryItem("RegisterAlphaBlendTextEdit")]
    public class RepositoryItemAlphaBlendTextEdit :RepositoryItemTextEdit {
        static RepositoryItemAlphaBlendTextEdit() {
            RegisterAlphaBlendTextEdit();
        }

        public RepositoryItemAlphaBlendTextEdit() : base() { }

        internal const string AlphaBlendTextEditName = "AlphaBlendTextEdit";
        public override string EditorTypeName {
            get { return AlphaBlendTextEditName; }
        }

        int fBackAlpha;
        public int BackAlpha {
            get { return fBackAlpha; }
            set {
                int v = value;
                if (v > 255)
                    v = 255;
                fBackAlpha = v;
                OnPropertiesChanged();
            }
        }

        public static void RegisterAlphaBlendTextEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(AlphaBlendTextEditName,
                typeof(AlphaBlendTextEdit), typeof(RepositoryItemAlphaBlendTextEdit),
                typeof(TextEditViewInfo), new TextEditPainter(), true));
        }

        public override void Assign(RepositoryItem item) {
            base.Assign(item);
            BeginUpdate();
            try {
                RepositoryItemAlphaBlendTextEdit source = (RepositoryItemAlphaBlendTextEdit)item;
                BackAlpha = source.BackAlpha;
            } finally { EndUpdate(); }
        }

        protected override void OnLoaded() {
            base.OnLoaded();
            Appearance.BackColor = Color.Transparent;
        }
    }
}