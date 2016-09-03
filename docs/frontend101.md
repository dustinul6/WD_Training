# Angualr JS 簡介

## Http 樣版
1. 建立一個專案資料夾 （ex. C:/Projects/angularDemo)
2. 用Visual Studio Code (VS Code) "開啟資料夾"
3. 新增檔案 /index.html
4. 貼上以下樣版：

```html
<!doctype html>

<html lang="en">
<head>
  <meta charset="utf-8">

  <title>這是標題</title>
  <meta name="description" content="The HTML5 Herald">
  <meta name="wjlin803" content="WD Information">

  <!--[if lt IE 9]>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.js"></script>
  <![endif]-->
</head>

<body>
	<h1> Hello, world</h1>
</body>
</html>
```


## 架設Local Server 
1. 安裝 [npm/Node.js](https://nodejs.org/en/)
我們要用的是 npm 這個javascript 套件管理系統，我們今天只用他提供的http server. 
直接用網頁中所提供的安裝程式安裝。

2. 用npm 安裝http-server
打開 "Node.js Command Prompt"，輸入
~~~
>npm install http-server -g
~~~
-g 代表在這一台電腦上裝這個套件，以後每一個專案都可以用。（有其他安裝方法只會給某一個app 安裝套件，其他app不會受到影響）

安裝完成以後，輸入
~~~
>http-server
~~~
即可啟動server

3. 用瀏覽器造訪 http://127.0.0.1:8080

## 加入 Angular JS
:::warning
心法：先搞清楚網頁怎麼樣可以動，先不要計較為什麼這樣會動。
:::
### 用Controller 控制 Html 
1. 下載 angular.js
官網：[https://angularjs.org/](https://angularjs.org/)
下載 Uncompressed 1.x 版，放進 "js/angular.js"

2. 新增檔案 "js/app.js" 
貼上以下code

```javascript
var app = angular.module('myApp', []);
//  建立一個 angular module, 
app.controller('myCtrl', ['$scope', function($scope){
	$scope.name = "Tzu-Yao";
	console.log("Hello, ", $scope.name);
}])
```
編輯 index.html 的 `<body>` ：

```html
<body ng-app="myApp">
<h1> Hello, world. </h1>
<div ng-controller="myCtrl">
	<h2>我是 {{name}} </h2>
</div>
</body>
```

- 在  `myCtrl` 這個controller 中，index.html 中的`{{name}}` 會對應到 app.js 中的 `$scope.name` 
- `console.log()` 會印出資料到 Chrome console中。 

### 雙向資料綁定
編輯 index.html 的 `<body>` ：
```html
<body ng-app="myApp">
<h1> Hello, world. </h1>
<div ng-controller="myCtrl">
	<form>
		<label for="myName">姓名</label>
		<input type="text" id="myName" ng-model="name">
	</form>
	<h2>我是 {{name}} </h2>
</div>
</body>
```

### Javascript 物件 ＆ Html 表格
編輯 app.js
```javascript
//前略 
app.controller('myCtrl', ['$scope', function($scope){
	$scope.name = "Tzu-Yao";
	console.log("Hello, ", $scope.name);
	$scope.student = {
		name : "林子堯",
		id : 1,
		score : 100
	};
	// $scope.student1 就是一個物件
}])
```
在index.html 中加入
```htmlmixed
<div ng-controller="myCtrl">
	<form>
		<label for="myName">姓名</label>
		<input type="text" id="myName" ng-model="name">
	</form>
	<h2>我是 {{name}} </h2>
	<table>
      <tr>
        <th>姓名</th>
        <th>學號</th>
        <th>分數</th>
      </tr>
      <tr>
        <td> {{student.name}} </td>
        <td> {{student.id}} </td>
        <td> {{student.score}} </td>
      </tr>
	</table>
</div>

```
如果有很多個學生（很多objects）呢？
物件會放進array裡

### Array of Objects 
把靜態資料寫在 app.js中
```javascript
//前略 
app.controller('myCtrl', ['$scope', function($scope){
	$scope.name = "Tzu-Yao";
	console.log("Hello, ", $scope.name);
	$scope.students = [{
		name : "林子堯",
		id : 1,
		score : 100
	},
	{
		name : "John",
		id : 2,
		score : 90
	},
	{
		name : "Mary",
		id : 3,
		score : 85
	}];
}])
```
### 用 `ng-repeat` 顯示Array資料
在index.html中
```html
<div ng-controller="myCtrl">
	<form>
	<label for="myName">姓名</label>
		<input type="text" id="myName" ng-model="name">
	</form>
	<h2>我是 {{name}} </h2>
	<table>
      <tr>
        <th>姓名</th>
        <th>學號</th>
        <th>分數</th>
      </tr>
      <tr ng-repeat="student in students">
        <td> {{student.name}} </td>
        <td> {{student.id}} </td>
        <td> {{student.score}} </td>
      </tr>
	</table>
</div>

```

把介面稍微變好看：

### Bootstrap
1. 用CDN 載入套件
- [JQuery](https://jquery.com/download/)
放在 `<body>` 中最下面

```html
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
</body>
```

- [Bootstrap](http://getbootstrap.com/) 
把css 放在`<head>`最下面
```html
<!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

```
把javascript 放在`<body>`中，JQuery的下面
```html
<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
```
幫`<table>` 加個 class
```html
<table class="table">
      <tr>
        <th>姓名</th>
        <th>學號</th>
        <th>分數</th>
      </tr>
      <tr ng-repeat="student in students">
        <td> {{student.name}} </td>
        <td> {{student.id}} </td>
        <td> {{student.score}} </td>
      </tr>
</table>
```

### 取得後端資料（呼叫API）
1. 我們用一個專門給開發者測試用的API
https://jsonplaceholder.typicode.com/

2. 用Postman測試一下，看data長什麼樣子
~~~
GET https://jsonplaceholder.typicode.com/users
~~~

3. 編輯 app.js