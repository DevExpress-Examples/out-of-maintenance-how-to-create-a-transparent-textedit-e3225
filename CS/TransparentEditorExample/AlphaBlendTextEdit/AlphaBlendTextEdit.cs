using System.ComponentModel;
using DevExpress.XtraEditors;
using TransparentEditorExample;

namespace ZBobb {
    public class AlphaBlendTextEdit :TextEdit {
        static AlphaBlendTextEdit() {
            RepositoryItemAlphaBlendTextEdit.RegisterAlphaBlendTextEdit();
        }

        public AlphaBlendTextEdit() : base() { }

        public override string EditorTypeName {
            get { return RepositoryItemAlphaBlendTextEdit.AlphaBlendTextEditName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemAlphaBlendTextEdit Properties {
            get { return (RepositoryItemAlphaBlendTextEdit)base.Properties; }
        }

        protected override TextBoxMaskBox CreateMaskBoxInstance() {
            return new AlphaBlendTextBox(this);
        }
    }
}