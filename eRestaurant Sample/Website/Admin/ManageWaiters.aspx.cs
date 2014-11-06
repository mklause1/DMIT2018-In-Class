using eRestaurant.BLL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Waiters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            // TODO: List the waiters in the dropdown list
        }//end if

    }
    protected void Add_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun(AddWaiter, "Added Waiter", "The new waiter was successfully added");
    }

    public void AddWaiter()
    {
        Waiter person = new Waiter()
        {
            FirstName = FirstName.Text,
            LastName = LastName.Text,
            Address = Address.Text,
            Phone = Phone.Text,
            HireDate = DateTime.Parse(HireDate.Text)
        };

        DateTime firedOn;
        if (DateTime.TryParse(ReleaseDate.Text, out firedOn))
            person.ReleaseDate = firedOn;

        var controller = new RestaurantAdminController();
        person.WaiterID = controller.AddWaiter(person);
        WaiterID.Text = person.WaiterID.ToString();
        // TODO: Re-populatedropdownList of waiters. And set the selected value as well.

    }//end AddWaiter

    public void UpdateWaiter()
    {
        Waiter person = new Waiter()
        {
            WaiterID = int.Parse(WaiterID.Text),
            FirstName = FirstName.Text,
            LastName = LastName.Text,
            Address = Address.Text,
            Phone = Phone.Text,
            HireDate = DateTime.Parse(HireDate.Text)
        };

        DateTime firedOn;
        if (DateTime.TryParse(ReleaseDate.Text, out firedOn))
            person.ReleaseDate = firedOn;

        var controller = new RestaurantAdminController();
        person.WaiterID = controller.AddWaiter(person);
        WaiterID.Text = person.WaiterID.ToString();
        // TODO: Re-populatedropdownList of waiters. And set the selected value as well.

    }//end UpdateWaiter
    protected void Update_Click(object sender, EventArgs e)
    {
        int temp;
        if (int.TryParse(WaiterID.Text, out temp))
            MessageUserControl.TryRun(UpdateWaiter, "Update succeded", "The waiter information was updated");
        else
            MessageUserControl.ShowInfo("Please Lookup waiter before clicking 'Update'");
    }
}