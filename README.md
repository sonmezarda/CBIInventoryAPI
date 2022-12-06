# CBILAB Envanter Sistemi Backend
# Product Body
```json
{
  "product": {
    "productID": 0,
    "productName": "string",
    "productCategoryID": 0,
    "productStockCount": 0,
    "productBoxID": 0,
    "productIMG": "string"
  },
  "productDetail": {
    "comments": {
      "c1": {
        "author": "string",
        "description": "string",
        "date": "string"
      },
      "c2": {
        "author": "string",
        "description": "string",
        "date": "string"
      },
      "c3": {
        "author": "string",
        "description": "string",
        "date": "string"
      }
    },
    "specs": {
      "Prop1": "string",
      "Prop2": "string",
      "Prop3": "string"
    }
  }
}
```

## PRODUCT API
* [GET] `/api/product`
	* Returns list of all products
* [POST] `/api/product`
	* BODY : Product
	* Adds new product to DB from body
	* Returns added product with unique ProductID
* [PUT] `/api/product`
	* BODY: Product
	* Updates product with given ProductID
	* Returns updated product
* [GET] `/api/product/{id}`
	* Returns product with given ID
* [DELETE] `/api/product/{id}`
	* Deletes product with given ID
	* Returns isSuccess (bool) -- it will change
## Comment API
