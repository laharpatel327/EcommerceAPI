# EcommerceAPI
Checkout endpoint added to calculate the total price with discounts applied for all watches requested.

\\ Checkout Endpoint is added to this project to do calculation on number of watches based on the discounted prices. 
Two projects are added:
EcommerceCheckoutAPI
CheckoutWebApi.UnitTests

Run the EcommerceChecoutAPI and it will open a swagger page and show the checkoutAPI. 
Also run the unit tests using test explorer. I have included one of the unit test to check if the price returned is correct or not. There can be other scenarios which can be covered through tests. 

I have used database to store the list given. I've not attached the database here in the GIT repo. Not sure how to do that.  
Unit Price is the actual price, discounted price is in discount and quantity is how many quantities applicable for the discounted price. 

WatchId	      WatchName	      UnitPrice	       discount	  Quantity
1	      Rolex	         100	         200	    3
2	      Michael Kors       80	         120	    2
3	      Swatch	         50	         NULL	    NULL
4	      Casio	         30	         NULL	    NULL

The API accepts list of watches (string) as a request and return the total price when checking out. Below are the images of successful returned responses. 

![image](https://github.com/laharpatel327/EcommerceAPI/assets/145035859/d0daadf6-9602-4f06-b1bf-9f03fb56925f)

![image](https://github.com/laharpatel327/EcommerceAPI/assets/145035859/150ca7f8-b2f0-4348-bd35-110b9f9f9d44)

Below is the WatchCatalogue table created

USE [Catalog]
GO

/****** Object:  Table [dbo].[WatchCatalogue]    Script Date: 9/14/2023 5:41:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WatchCatalogue](
	[WatchId] [int] IDENTITY(1,1) NOT NULL,
	[WatchName] [varchar](50) NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[discount] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[WatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


