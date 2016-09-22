# Odata 語法

## $filter

1. 查詢 SUBNAME 等於 '大霖'
``` 
http://localhost:56490/odata/PUR010?$filter=SUBNAME eq '大霖'
```

2. 查詢 IN_TYPE 包含 '五金' 字串
```
http://localhost:56490/odata/PUR010?$filter=contains(IN_TYPE, '五金')
```

3. 查詢 MOD_DATE == 2016-06-21T08:27:46-04:00
時間格式為 DateTimeOffSet, 多了時區
```
http://localhost:56490/odata/PUR010?$filter=MOD_DATE eq 2016-06-21T08:27:46-04:00
```

4. 查詢 MOD_DATE > 2016-06-21T08:27:46-04:00
```
http://localhost:56490/odata/PUR010?$filter=MOD_DATE gt 2016-06-21T08:27:46-04:00
```

- "==" : eq (equal)
- ">" : gt (greater than)
- "<" : lt (less than)
- ">=" : ge (greater or equal to)
- "<=" : le (less or equal to)
- "!=" : ne (not equal )

5.  查詢 DATE1 > 2016-06-21T08:27:46-04:00
http://localhost:56490/odata/PUR010?$filter=MOD_DATE eq null

6. and, or 

```
http://localhost:56490/odata/PUR010?$filter=MOD_DATE eq null and DATE1 lt 2008-04-24T15:48:05-04:00
```

## $expand

```
http://localhost:56490/odata/Products?$expand=Brand
```

```
{
  "@odata.context": "http://localhost:56490/odata/$metadata#Products",
  "value": [
    {
      "Id": 1,
      "Name": "Computer",
      "Price": 200,
      "Description": "Good product",
      "BrandId": 1,
      "Brand": {
        "Name": "ACER",
        "Id": 1
      }
    },
    {
      "Id": 2,
      "Name": "Laptop",
      "Price": 150,
      "Description": "Wonderful!!",
      "BrandId": 2,
      "Brand": {
        "Name": "ASUS",
        "Id": 2
      }
    },
    {
      "Id": 3,
      "Name": "Monitor",
      "Price": 250,
      "Description": null,
      "BrandId": 1,
      "Brand": {
        "Name": "ACER",
        "Id": 1
      }
    },
    {
      "Id": 4,
      "Name": "Cell Phone",
      "Price": 300,
      "Description": null,
      "BrandId": 3,
      "Brand": {
        "Name": "HP",
        "Id": 3
      }
    },
    {
      "Id": 6,
      "Name": "123",
      "Price": 100,
      "Description": "good",
      "BrandId": 1,
      "Brand": {
        "Name": "ACER",
        "Id": 1
      }
    }
  ]
}
```
## single result
```
http://localhost:56490/odata/Products(1)
```
```
http://localhost:56490/odata/Products(1)?$expand=Brand
```
```
{
  "@odata.context": "http://localhost:56490/odata/$metadata#Products/$entity",
  "Id": 1,
  "Name": "Computer",
  "Price": 200,
  "Description": "Good product",
  "BrandId": 1,
  "Brand": {
    "Name": "ACER",
    "Id": 1
  }
}
```


## Relational result
```
http://localhost:56490/odata/Products(1)/Brand
```
```
{
  "@odata.context": "http://localhost:56490/odata/$metadata#Brands/$entity",
  "Name": "ACER",
  "Id": 1
}
```
與下列相同
```
http://localhost:56490/odata/Brands(1)
```

## 