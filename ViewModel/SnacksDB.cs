using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class SnacksDB : BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new Snacks() as BaseEntity; //יצירת עצם חדש מסוג
        }

        //Reader-מילוי העצם בערכים מה
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Snacks snack = (Snacks)entity;
            snack.Id = (int)this.reader["ID"];
            snack.SnackName = (string)this.reader["SnackName"];
            return snack;
        }

        public SnacksList SelectAll()
        {
            command.CommandText = "SELECT * FROM TblSnacks";
            SnacksList snacksList = new SnacksList(base.ExecuteCommand());
            return snacksList;
        }

        public Snacks SelectById(int id)
        {
            command.CommandText = $"SELECT * FROM TblSnacks WHERE ID={id}";
            SnacksList snacksList = new SnacksList(base.ExecuteCommand());
            if (snacksList.Count == 0)
                return null;
            return snacksList[0];
        }

        public SnacksList SelectByUser(User user)
        {
            command.CommandText = "SELECT *  FROM (TblUserSnack INNER JOIN TblSnacks ON TblUserSnack.userSnack = tblSnacks.ID) " 
                + $" WHERE UserId={user.Id}";
            SnacksList snacksList = new SnacksList(base.ExecuteCommand());
            return snacksList;
        }
    }
}

