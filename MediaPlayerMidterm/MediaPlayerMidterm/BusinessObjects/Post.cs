using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DatabaseHelper;



namespace BusinessObjects
{
    public class Post : HeaderData
    {
        #region Private Members
        private String _MusicPath = string.Empty;
        private String _ArtistName = string.Empty;
        private String _TrackName = string.Empty;
        private String _FilePath = String.Empty;
        private String _RelativeFileName = String.Empty;
        #endregion

        #region Public Properties

        public String FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }
        public String RelativeFileName
        {
            get { return _RelativeFileName; }
            set { _RelativeFileName = value; }
        }
    
        public String MusicPath
        {
            get { return _MusicPath; }
            set
            {
                if (_MusicPath != value)
                {
                    _MusicPath = value;
                    base.IsDirty = true;
                    Boolean Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public string ArtistName
        {
            get { return _ArtistName; }
            set
            {
                if (_ArtistName != value)
                {
                    _ArtistName = value;
                    base.IsDirty = true;
                    Boolean Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public string TrackName
        {
            get { return _TrackName; }
            set
            {
                if (_TrackName != value)
                {
                    _TrackName = value;
                    base.IsDirty = true;
                    Boolean Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        #endregion

        #region Private Methods
        private Boolean Insert(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblPostINSERT";
                database.Command.Parameters.Add("@MusicPath", SqlDbType.VarChar).Value = _MusicPath;
                database.Command.Parameters.Add("@ArtistName", SqlDbType.VarChar).Value = _ArtistName;
                database.Command.Parameters.Add("@TrackName", SqlDbType.VarChar).Value = _TrackName;

                // Provides the empty buckets
                base.Initialize(database, Guid.Empty);
                database.ExecuteNonQuery();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);


            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            //System.IO.File.Delete(_FilePath);
            return result;
        }
        private Boolean Update(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblPostUPDATE";
                database.Command.Parameters.Add("@MusicPath", SqlDbType.VarChar).Value = _MusicPath;
                database.Command.Parameters.Add("@ArtistName", SqlDbType.VarChar).Value = _ArtistName;
                database.Command.Parameters.Add("@TrackName", SqlDbType.VarChar).Value = _TrackName;

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQuery();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            return result;
        }
        private Boolean Delete(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblPostDELETE";

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQuery();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            return result;
        }
       
        #endregion

        #region Public Methods
        public Post GetById(Guid id)
        {
            Database database = new Database("MattsPracticeDatabase");
            DataTable dt = new DataTable();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblPostGetById";
            database.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id;
            dt = database.ExecuteQuery();
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                base.Initialize(dr);
                InitializeBusinessData(dr);
                base.IsNew = false;
                base.IsDirty = false;
            }

            return this;
        }
        public void InitializeBusinessData(DataRow dr)
        {
          
            _MusicPath = dr["MusicPath"].ToString();
            _ArtistName = dr["ArtistName"].ToString();
            _TrackName = dr["TrackName"].ToString();
            String filepath = System.IO.Path.Combine(_FilePath, Id.ToString() + ".mp3");
            _RelativeFileName = System.IO.Path.Combine("UploadedMusic", Id.ToString() + ".mp3");

        }
        public Boolean IsSavable()
        {
            Boolean result = false;

            if ((base.IsDirty == true))
            {
                result = true;
            }

            return result;
        }
        public Post Save()
        {
            Boolean result = true;
            Database database = new Database("MattsPracticeDatabase");
            if (base.IsNew == true && IsSavable() == true)
            {
                result = Insert(database);
            }
            else if (base.Deleted == true && base.IsDirty)
            {
                result = Delete(database);
            }
            else if (base.IsNew == false && IsSavable() == true)
            {
                result = Update(database);
            }

            if (result == true)
            {
                base.IsDirty = false;
                base.IsNew = false;
            }
            return this;
        }
        #endregion

        #region Public Events

        #endregion

        #region Public Event Handlers

        #endregion

        #region Construction

        #endregion
    }
}
