# SpeeDine (Group 10) CPSC 481

## Authors
1. Alyssa Lee (alyssa.lee1@ucalgary.ca)
2. Shafin Kheraj (shafin.kheraj1@ucalgary.ca)
3. Rachael Nguyen (rachael.nguyen@ucalgary.ca)
4. Lana Nieves (lanaisabella.nieves@ucalgary.ca)
5. Suvrat Kumra (suvrat.kumra@ucalgary.ca, https://www.linkedin.com/in/suvrat-kumra-420017193/)

## Set-up
Please ensure that your version of Visual Studio 2022 has the "ASP.NET and web development" package and can run .NET 5.

## What is SpeeDine?
SpeeDine is a restaurant ordering web application designed for mobile devices. Restaurant can use the SpeeDine website to give its patrons a fast, efficient, and fun dining experience! Instead of using paper menus and having to order through a waiter, guests can use SpeeDine to control the ordering process in the palm on their hands! To access SpeeDine, guests can simply scan the QR code at their table on their own devices. Each device will be tied to that specific guest and to that specific table. SpeeDine gives patrons the ability to look through the menu, order items, split the bill, request payment, call the waiter, and more! 

## Features
- Website that can be accessed from any mobile device
- Multiple devices interacting with features 
- Convenient nav bar that directs to all the important pages
- Help buttons available for every page
- View menu items by category
- Easily sort through menu items by dietary preference
- Easily compare menu items with a "Pinned" feature
- Easily choose a side and make a special request when ordering
- Edit menu items already added to the Cart
- Instantly place orders
- Place several orders in one sitting without having to wait for a waiter
- View the status of orders (Pending Order, Waiting, Delivered)
- Call the waiter for any help at all!
- Ability to choose between requesting the entire bill or splitting it amongst guests
- Easy-to-use interface for splitting the bill -- simply pick the items you'd like to pay for! The cost of items can be shared by several people
- Convenient review screen that allows guests to share their thoughts while allowing the restaurant to gain feedback on their services

## Walkthrough
As with most ordering systems (e.g., Amazon, Uber Eats), the natural flow of our app is:
1. From the Welcome screen, enter your name.
2. From the Menu screen, place items in the Cart.
3. From the Cart screen, order the items.
4. From the Ordered screen, look at your orders and then choose how to split the bill (if at all).
5. Payment happens (separate from the app).
6. Opportunity for guest to give feedback.
Proceed below for detailed instructions!

### Welcome screen, "/"
1. Enter your name into the text box to get started.
2. Click "Continue to Menu".

### Menu, "/menu/Popular"
From the Welcome screen, you're automatically redirected to the Menu. Note that you're under the "Menu" section in the navigation bar.
In the menu, you're automatically redirected to the "Popular" section. Feel free to navigate through the categories at the top (left to right scrolling).
#### Using "Sort by Diet" feature
Use this feature to easily find foods that fit your diet.
1. Click the filter icon next to "Sort By Diet".
2. In the pop-up menu, select the diets you'd like to filter for (selecting several is permitted).
3. In the pop-up menu, select "Clear All" if you'd like to clear what you've selected.
4. Click the filter icon again to remove the pop-up menu.
5. On the menu screen, the items that fit ALL the criteria you've selected will appear. If none have appeared, the error message "Sorry, there are no menu items that match" will appear instead, telling you that there are no items that fit ALL the criteria you've selected.
#### Using the "Pinned" feature
Use this feature to easily compare items on the menu by shortlisting them, regardless of their section. 
1. For each menu item, there is a pin icon on the bottom-right. 
2. Click the pin icon to "pin" the item.
3. Navigate to the "Pinned" section in the categories bar. 
4. The items you've pinned will be there, allowing you to easily compare them.
#### Adding an item to the Cart
1. Click any menu item that you'd like to add to the Cart (and thus, eventually order).
2. A pop-up will appear of the item's details, sides (if any), Special Instructions text box, and quantity selector.
3. If the item comes with sides, click the radio button for the side you'd like to order; this mandatory.
4. If you'd like, enter any special instructions in the textbox.
5. You can duplicate order (with that chosen side and the given instructions), increase the quantity using the "+" button. Similarly, you can decrease the quantity (to 1, minimum) by using the "-" button. 
6. To add this item to the Cart, click the "Add to Cart" button. To instead cancel this entire process, scroll back up and click the "Back to Menu button". Either way, you'll be redirected back to the Menu page.
8. If you added the item to the Cart, the "Cart" button at the bottom of the menu page should say "Cart (1)" now. Click it to see the item you ordered!

### Cart, "/cart"
Click the Cart button in the navigation bar to navigate to the Cart page, after placing your items in the Cart.
Click the "Place Table Order" button to send the order to the kitchen whenever the table is ready. Note that several orders can be placed throughout your time there, so it doesn't matter if someone forgets to order something!
#### Features in the Cart
- Your items and the other guests' items are shown. When other guests at the table add their items to the Cart, it updates automatically.
- Only your items can be removed/modified.
- Click the "x" on the top-right corner to remove it from the Cart. Note that if that this deletes any additional quantities of this item.
- Click the pencil icon on the bottom-right corner to edit the item. This will pull up the screen that allows you to choose the item's side and special instructions.
- Click the "-" and "+" buttons to decrease and increase the duplicates of this item in the Cart, respectively. You cannot have less than 1 of the item.

### Ordered, "/order"
Click the Ordered button in the navigation bar to navigate to the Ordered page, after ordering your items. Once everyone is ready for the bill, there are two options: to ask for a single bill (if one person is paying), or to split the bill between guests.
#### Features in Ordered
- You can see your table's orders and their statuses (Pending Order, Waiting, Delivered). Immediately after being ordered, each item has the "Waiting" status. After the item arrives at the table, it changes to the "Delivered" status. 
- Each guest has a subtotal based on the items they ordered from their device. (However, this is not necessarily how much the guest will pay. Due to the billing features, this can change.)
- There's a table total at the bottom of the page.

### Entire Bill, "/order/EntireBill/Billing"
If you choose a single bill, this screen will show the items everyone ordered (grouped together), and the subtotal. It should be the same as the Table Total in the Ordered page. Once the table is ready to pay, click "Proceed to Payment".
#### Features in Entire Bill
- There is a wizard at the top of the page that allows the guests to track which step they're on.
- There's also a back button if the table decides they're not ready for the bill, or if they'd like to split it instead.

### Split Bill, "/order/SplitBill"
If you choose to split the bill, this shows an interactive screen that allows the guests to choose what to pay for, based on the items. When guests interact with it, it updates automatically on the other devices.
#### How to use Split Bill functionality
- By default, the guests will be paying for the items they ordered from their devices.
- Guests can unselect items if they don't want to pay for them. However, the app will not allow them to proceed unless every item is paid for by somebody.
- Guests split the cost of an item when several guests click on one item. This will be signified by the text on the item and the background color changing.
- The subtotal at the bottom updates whenever a guest selects/de-selects an item.
#### Other features in Split Bill
- There is a wizard at the top of the page that allows the guests to track which step they're on.
- There's also a back button if the table decides they're not ready for the bill, or if they'd like only a single bill instead.
- Pro-tip: to evenly split the entire bill amongst everyone, have every guest at the table select every item.


### Billing of Split Bill, "/order/SplitBill/Billing"
After splitting the bill, this screen will show the items that the guest on that device ordered, and the subtotal. Any items that were split will have a reduced cost. Once the guest is ready to pay, click "Proceed to Payment".
#### Features in Split Bill's Billing
- There is a wizard at the top of the page that allows the guests to track which step they're on.
- There's also a back button if the table decides they're not ready for the bill, or if they'd like to change how it's split instead.

### Payment, "/order/.../Payment"
This is a simple screen that tells the guest(s) that the waiter is on their way with the bill(s) to receive the payment.

### Review, "/order/.../Review"
After payment, the waiter will navigate the guests' devices to the Review page. Here, the guests can easily leave feedback by selecting a smiley face and leaving a message. Guests can click "Submit" without entering anything if they'd like to skip this.

### Thank You, "/thanks"
A ncie thank-you page to thank the guest for dining with us and using SpeeDine!

(Instructions for README)
What cases/functions were implemented? What data should be entered at which times? To ensure that we don't miss any of the best features of your system you should word your instructions as an exact walkthrough of what should be typed and what controls should be set to what values. Everything must run from the installation directory (Hint: use App. Path. This means that you should use relative rather than absolute paths.
