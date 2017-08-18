using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EA.Data;
using EA.Model;
using EA.Models;
using EA.Models.SqlModels;

namespace EA.Form.CardForm
{
    public partial class AttachCardForm : XtraForm
    {
        private readonly int _parentCardId;

        public AttachCardForm(int parentCardId)
        {
            _parentCardId = parentCardId;
            InitializeComponent();
        }

        private void buttonSearchCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditCardCode.Text))
            {
                XtraMessageBox.Show("Введите код чертежа");
                return;
            }

            string code = textEditCardCode.Text;

            gridControlCards.DataSource = new CardModel().GetCardsByCode(new List<Card>(), code);
        }

        private void buttonAttachCard_Click(object sender, EventArgs e)
        {
            GetSelectedCardData();
        }

        private void gridViewCards_DoubleClick(object sender, EventArgs e)
        {
            GetSelectedCardData();
        }

        private void GetSelectedCardData()
        {
            if (gridViewCards.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Выберите запись!");
                return;
            }
            string cardCode = gridViewCards.GetRowCellValue(gridViewCards.FocusedRowHandle, "Code") as string;
            new DialogModel().ShowYesNoMessageBox("Присоединить карточку " + cardCode, "Присоединение карточки");
            int cardId = Convert.ToInt32(gridViewCards.GetRowCellValue(gridViewCards.FocusedRowHandle, "CardId"));

            if (new AttachCardSqlModel().AttachCard(cardId, _parentCardId)) Close();


        }

        
    }
}