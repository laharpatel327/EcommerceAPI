# EcommerceAPI
Checkout endpoint added to calculate the toal price for all watches requested.

\\ Checkout Endpoint is added to this project to do calculation on final prices based on the discount prices. 
Two projects are added:
EcommerceCheckoutAPI
CheckoutWebApi.UnitTests

Run the EcommerceChecoutAPI and it will open a swagger page and show the checkoutAPI. 
Also run the unit tests using test explorer. I have included one of the unit test to check if the price returned is correct or not. There can be other scenarios which can be covered through tests. 

I have used database to store the list given. I've not attached the database here in the GIT repo. Not sure how to do that.  
Unit Price is the actual price, discounted price is in discount and quantity is how many quantities applicable for the discounted price. 

WatchId	WatchName	   UnitPrice	 discount	  Quantity
1	      Rolex	         100	         200	    3
2	      Michael Kors    80	         120	    2
3	      Swatch	        50	         NULL	    NULL
4	      Casio	          30	         NULL	    NULL

The API accepts list of watches (string) as a request and return the total price when checking out. Below are the images of successful returned responses. 

![image](https://github.com/laharpatel327/EcommerceAPI/assets/145035859/d0daadf6-9602-4f06-b1bf-9f03fb56925f)

![image](https://github.com/laharpatel327/EcommerceAPI/assets/145035859/150ca7f8-b2f0-4348-bd35-110b9f9f9d44)

