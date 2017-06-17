using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.MsSqlCommands;

namespace DataAccess.MSSQL.Sicap
{
	/// <summary>
	/// Controla la ejecucion de los procedimientos almacenados de la conexion Sicap.
	/// </summary>
	public class Sicap : IDisposable
	{
		#region Properties

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Addimage.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Addimage Addimage = new DataAccess.MsSqlCommands.Sicap.Addimage();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Areaadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Areaadd Areaadd = new DataAccess.MsSqlCommands.Sicap.Areaadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Areadelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Areadelete Areadelete = new DataAccess.MsSqlCommands.Sicap.Areadelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Arealist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Arealist Arealist = new DataAccess.MsSqlCommands.Sicap.Arealist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Areaupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Areaupdate Areaupdate = new DataAccess.MsSqlCommands.Sicap.Areaupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Backupdb.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Backupdb Backupdb = new DataAccess.MsSqlCommands.Sicap.Backupdb();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Binnacleadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Binnacleadd Binnacleadd = new DataAccess.MsSqlCommands.Sicap.Binnacleadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Binnaclelist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Binnaclelist Binnaclelist = new DataAccess.MsSqlCommands.Sicap.Binnaclelist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Branchofficeadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Branchofficeadd Branchofficeadd = new DataAccess.MsSqlCommands.Sicap.Branchofficeadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Branchofficedelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Branchofficedelete Branchofficedelete = new DataAccess.MsSqlCommands.Sicap.Branchofficedelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Branchofficelist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Branchofficelist Branchofficelist = new DataAccess.MsSqlCommands.Sicap.Branchofficelist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Branchofficeupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Branchofficeupdate Branchofficeupdate = new DataAccess.MsSqlCommands.Sicap.Branchofficeupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Catalogadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Catalogadd Catalogadd = new DataAccess.MsSqlCommands.Sicap.Catalogadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Catalogdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Catalogdelete Catalogdelete = new DataAccess.MsSqlCommands.Sicap.Catalogdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Cataloglist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Cataloglist Cataloglist = new DataAccess.MsSqlCommands.Sicap.Cataloglist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Catalogupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Catalogupdate Catalogupdate = new DataAccess.MsSqlCommands.Sicap.Catalogupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Changepassword.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Changepassword Changepassword = new DataAccess.MsSqlCommands.Sicap.Changepassword();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Checkrrestoreuser.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Checkrrestoreuser Checkrrestoreuser = new DataAccess.MsSqlCommands.Sicap.Checkrrestoreuser();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Configget.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Configget Configget = new DataAccess.MsSqlCommands.Sicap.Configget();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Configset.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Configset Configset = new DataAccess.MsSqlCommands.Sicap.Configset();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expenseadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expenseadd Expenseadd = new DataAccess.MsSqlCommands.Sicap.Expenseadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expensedelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expensedelete Expensedelete = new DataAccess.MsSqlCommands.Sicap.Expensedelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expenselist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expenselist Expenselist = new DataAccess.MsSqlCommands.Sicap.Expenselist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expenseupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expenseupdate Expenseupdate = new DataAccess.MsSqlCommands.Sicap.Expenseupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Faenaadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Faenaadd Faenaadd = new DataAccess.MsSqlCommands.Sicap.Faenaadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Faenadelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Faenadelete Faenadelete = new DataAccess.MsSqlCommands.Sicap.Faenadelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Faenalist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Faenalist Faenalist = new DataAccess.MsSqlCommands.Sicap.Faenalist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Faenaprint.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Faenaprint Faenaprint = new DataAccess.MsSqlCommands.Sicap.Faenaprint();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Faenaupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Faenaupdate Faenaupdate = new DataAccess.MsSqlCommands.Sicap.Faenaupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Getbuttonsrol.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Getbuttonsrol Getbuttonsrol = new DataAccess.MsSqlCommands.Sicap.Getbuttonsrol();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Getimage.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Getimage Getimage = new DataAccess.MsSqlCommands.Sicap.Getimage();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantadd Habitantadd = new DataAccess.MsSqlCommands.Sicap.Habitantadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantdelete Habitantdelete = new DataAccess.MsSqlCommands.Sicap.Habitantdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantfaenaadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantfaenaadd Habitantfaenaadd = new DataAccess.MsSqlCommands.Sicap.Habitantfaenaadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantfaenalist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantfaenalist Habitantfaenalist = new DataAccess.MsSqlCommands.Sicap.Habitantfaenalist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantfaenapaidoutdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantfaenapaidoutdelete Habitantfaenapaidoutdelete = new DataAccess.MsSqlCommands.Sicap.Habitantfaenapaidoutdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantfaenapaidoutlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantfaenapaidoutlist Habitantfaenapaidoutlist = new DataAccess.MsSqlCommands.Sicap.Habitantfaenapaidoutlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantlist Habitantlist = new DataAccess.MsSqlCommands.Sicap.Habitantlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantprint.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantprint Habitantprint = new DataAccess.MsSqlCommands.Sicap.Habitantprint();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantupdate Habitantupdate = new DataAccess.MsSqlCommands.Sicap.Habitantupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Menulist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Menulist Menulist = new DataAccess.MsSqlCommands.Sicap.Menulist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Menuprincipallist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Menuprincipallist Menuprincipallist = new DataAccess.MsSqlCommands.Sicap.Menuprincipallist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Menusecondarybyuserlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Menusecondarybyuserlist Menusecondarybyuserlist = new DataAccess.MsSqlCommands.Sicap.Menusecondarybyuserlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Menusecondaryllist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Menusecondaryllist Menusecondaryllist = new DataAccess.MsSqlCommands.Sicap.Menusecondaryllist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentadd Paymentadd = new DataAccess.MsSqlCommands.Sicap.Paymentadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentdelete Paymentdelete = new DataAccess.MsSqlCommands.Sicap.Paymentdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentexist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentexist Paymentexist = new DataAccess.MsSqlCommands.Sicap.Paymentexist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentlist Paymentlist = new DataAccess.MsSqlCommands.Sicap.Paymentlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentperyear.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentperyear Paymentperyear = new DataAccess.MsSqlCommands.Sicap.Paymentperyear();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentprint.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentprint Paymentprint = new DataAccess.MsSqlCommands.Sicap.Paymentprint();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymenttotalbyperiod.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymenttotalbyperiod Paymenttotalbyperiod = new DataAccess.MsSqlCommands.Sicap.Paymenttotalbyperiod();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentupdate Paymentupdate = new DataAccess.MsSqlCommands.Sicap.Paymentupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Provideradd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Provideradd Provideradd = new DataAccess.MsSqlCommands.Sicap.Provideradd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Providerdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Providerdelete Providerdelete = new DataAccess.MsSqlCommands.Sicap.Providerdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Providerlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Providerlist Providerlist = new DataAccess.MsSqlCommands.Sicap.Providerlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Providerupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Providerupdate Providerupdate = new DataAccess.MsSqlCommands.Sicap.Providerupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Reportconcentrated.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Reportconcentrated Reportconcentrated = new DataAccess.MsSqlCommands.Sicap.Reportconcentrated();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Reportpayments1.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Reportpayments1 Reportpayments1 = new DataAccess.MsSqlCommands.Sicap.Reportpayments1();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Reportpaymentyear1.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Reportpaymentyear1 Reportpaymentyear1 = new DataAccess.MsSqlCommands.Sicap.Reportpaymentyear1();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Roleadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Roleadd Roleadd = new DataAccess.MsSqlCommands.Sicap.Roleadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Roledelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Roledelete Roledelete = new DataAccess.MsSqlCommands.Sicap.Roledelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Roleupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Roleupdate Roleupdate = new DataAccess.MsSqlCommands.Sicap.Roleupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Rolget.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Rolget Rolget = new DataAccess.MsSqlCommands.Sicap.Rolget();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Rollist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Rollist Rollist = new DataAccess.MsSqlCommands.Sicap.Rollist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Updaterolemenu.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Updaterolemenu Updaterolemenu = new DataAccess.MsSqlCommands.Sicap.Updaterolemenu();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Updaterolemenudelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Updaterolemenudelete Updaterolemenudelete = new DataAccess.MsSqlCommands.Sicap.Updaterolemenudelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Useradd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Useradd Useradd = new DataAccess.MsSqlCommands.Sicap.Useradd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userdelete Userdelete = new DataAccess.MsSqlCommands.Sicap.Userdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Usergetfingers.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Usergetfingers Usergetfingers = new DataAccess.MsSqlCommands.Sicap.Usergetfingers();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userlist Userlist = new DataAccess.MsSqlCommands.Sicap.Userlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userlogin.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userlogin Userlogin = new DataAccess.MsSqlCommands.Sicap.Userlogin();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userrestore.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userrestore Userrestore = new DataAccess.MsSqlCommands.Sicap.Userrestore();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userupdate Userupdate = new DataAccess.MsSqlCommands.Sicap.Userupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakeadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakeadd Waterintakeadd = new DataAccess.MsSqlCommands.Sicap.Waterintakeadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakedelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakedelete Waterintakedelete = new DataAccess.MsSqlCommands.Sicap.Waterintakedelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakefindbyap.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakefindbyap Waterintakefindbyap = new DataAccess.MsSqlCommands.Sicap.Waterintakefindbyap();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakelist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakelist Waterintakelist = new DataAccess.MsSqlCommands.Sicap.Waterintakelist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakeprint.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakeprint Waterintakeprint = new DataAccess.MsSqlCommands.Sicap.Waterintakeprint();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakeupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakeupdate Waterintakeupdate = new DataAccess.MsSqlCommands.Sicap.Waterintakeupdate();


		#endregion

		#region Methods

		public void Dispose()
		{
			if (this.Addimage != null)
				this.Addimage.Dispose();

			if (this.Areaadd != null)
				this.Areaadd.Dispose();

			if (this.Areadelete != null)
				this.Areadelete.Dispose();

			if (this.Arealist != null)
				this.Arealist.Dispose();

			if (this.Areaupdate != null)
				this.Areaupdate.Dispose();

			if (this.Backupdb != null)
				this.Backupdb.Dispose();

			if (this.Binnacleadd != null)
				this.Binnacleadd.Dispose();

			if (this.Binnaclelist != null)
				this.Binnaclelist.Dispose();

			if (this.Branchofficeadd != null)
				this.Branchofficeadd.Dispose();

			if (this.Branchofficedelete != null)
				this.Branchofficedelete.Dispose();

			if (this.Branchofficelist != null)
				this.Branchofficelist.Dispose();

			if (this.Branchofficeupdate != null)
				this.Branchofficeupdate.Dispose();

			if (this.Catalogadd != null)
				this.Catalogadd.Dispose();

			if (this.Catalogdelete != null)
				this.Catalogdelete.Dispose();

			if (this.Cataloglist != null)
				this.Cataloglist.Dispose();

			if (this.Catalogupdate != null)
				this.Catalogupdate.Dispose();

			if (this.Changepassword != null)
				this.Changepassword.Dispose();

			if (this.Checkrrestoreuser != null)
				this.Checkrrestoreuser.Dispose();

			if (this.Configget != null)
				this.Configget.Dispose();

			if (this.Configset != null)
				this.Configset.Dispose();

			if (this.Expenseadd != null)
				this.Expenseadd.Dispose();

			if (this.Expensedelete != null)
				this.Expensedelete.Dispose();

			if (this.Expenselist != null)
				this.Expenselist.Dispose();

			if (this.Expenseupdate != null)
				this.Expenseupdate.Dispose();

			if (this.Faenaadd != null)
				this.Faenaadd.Dispose();

			if (this.Faenadelete != null)
				this.Faenadelete.Dispose();

			if (this.Faenalist != null)
				this.Faenalist.Dispose();

			if (this.Faenaprint != null)
				this.Faenaprint.Dispose();

			if (this.Faenaupdate != null)
				this.Faenaupdate.Dispose();

			if (this.Getbuttonsrol != null)
				this.Getbuttonsrol.Dispose();

			if (this.Getimage != null)
				this.Getimage.Dispose();

			if (this.Habitantadd != null)
				this.Habitantadd.Dispose();

			if (this.Habitantdelete != null)
				this.Habitantdelete.Dispose();

			if (this.Habitantfaenaadd != null)
				this.Habitantfaenaadd.Dispose();

			if (this.Habitantfaenalist != null)
				this.Habitantfaenalist.Dispose();

			if (this.Habitantfaenapaidoutdelete != null)
				this.Habitantfaenapaidoutdelete.Dispose();

			if (this.Habitantfaenapaidoutlist != null)
				this.Habitantfaenapaidoutlist.Dispose();

			if (this.Habitantlist != null)
				this.Habitantlist.Dispose();

			if (this.Habitantprint != null)
				this.Habitantprint.Dispose();

			if (this.Habitantupdate != null)
				this.Habitantupdate.Dispose();

			if (this.Menulist != null)
				this.Menulist.Dispose();

			if (this.Menuprincipallist != null)
				this.Menuprincipallist.Dispose();

			if (this.Menusecondarybyuserlist != null)
				this.Menusecondarybyuserlist.Dispose();

			if (this.Menusecondaryllist != null)
				this.Menusecondaryllist.Dispose();

			if (this.Paymentadd != null)
				this.Paymentadd.Dispose();

			if (this.Paymentdelete != null)
				this.Paymentdelete.Dispose();

			if (this.Paymentexist != null)
				this.Paymentexist.Dispose();

			if (this.Paymentlist != null)
				this.Paymentlist.Dispose();

			if (this.Paymentperyear != null)
				this.Paymentperyear.Dispose();

			if (this.Paymentprint != null)
				this.Paymentprint.Dispose();

			if (this.Paymenttotalbyperiod != null)
				this.Paymenttotalbyperiod.Dispose();

			if (this.Paymentupdate != null)
				this.Paymentupdate.Dispose();

			if (this.Provideradd != null)
				this.Provideradd.Dispose();

			if (this.Providerdelete != null)
				this.Providerdelete.Dispose();

			if (this.Providerlist != null)
				this.Providerlist.Dispose();

			if (this.Providerupdate != null)
				this.Providerupdate.Dispose();

			if (this.Reportconcentrated != null)
				this.Reportconcentrated.Dispose();

			if (this.Reportpayments1 != null)
				this.Reportpayments1.Dispose();

			if (this.Reportpaymentyear1 != null)
				this.Reportpaymentyear1.Dispose();

			if (this.Roleadd != null)
				this.Roleadd.Dispose();

			if (this.Roledelete != null)
				this.Roledelete.Dispose();

			if (this.Roleupdate != null)
				this.Roleupdate.Dispose();

			if (this.Rolget != null)
				this.Rolget.Dispose();

			if (this.Rollist != null)
				this.Rollist.Dispose();

			if (this.Updaterolemenu != null)
				this.Updaterolemenu.Dispose();

			if (this.Updaterolemenudelete != null)
				this.Updaterolemenudelete.Dispose();

			if (this.Useradd != null)
				this.Useradd.Dispose();

			if (this.Userdelete != null)
				this.Userdelete.Dispose();

			if (this.Usergetfingers != null)
				this.Usergetfingers.Dispose();

			if (this.Userlist != null)
				this.Userlist.Dispose();

			if (this.Userlogin != null)
				this.Userlogin.Dispose();

			if (this.Userrestore != null)
				this.Userrestore.Dispose();

			if (this.Userupdate != null)
				this.Userupdate.Dispose();

			if (this.Waterintakeadd != null)
				this.Waterintakeadd.Dispose();

			if (this.Waterintakedelete != null)
				this.Waterintakedelete.Dispose();

			if (this.Waterintakefindbyap != null)
				this.Waterintakefindbyap.Dispose();

			if (this.Waterintakelist != null)
				this.Waterintakelist.Dispose();

			if (this.Waterintakeprint != null)
				this.Waterintakeprint.Dispose();

			if (this.Waterintakeupdate != null)
				this.Waterintakeupdate.Dispose();


		}

		#endregion
	}
}