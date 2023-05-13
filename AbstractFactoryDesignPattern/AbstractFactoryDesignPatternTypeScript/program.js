var Page = /** @class */ (function () {
    function Page(title, header, body, footer) {
        this.title = title;
        this.header = header;
        this.body = body;
        this.footer = footer;
    }
    return Page;
}());
var Header = /** @class */ (function () {
    function Header() {
    }
    return Header;
}());
var Body = /** @class */ (function () {
    function Body() {
    }
    return Body;
}());
var Footer = /** @class */ (function () {
    function Footer() {
    }
    return Footer;
}());
var HomePageFactory = /** @class */ (function () {
    function HomePageFactory() {
        this.Title = "Home Page";
    }
    HomePageFactory.prototype.createBody = function () {
        return new Body();
    };
    HomePageFactory.prototype.createFooter = function () {
        return new Footer();
    };
    HomePageFactory.prototype.createHeader = function () {
        return new Header();
    };
    return HomePageFactory;
}());
var ProductPageFactory = /** @class */ (function () {
    function ProductPageFactory() {
        this.Title = "Product Page";
    }
    ProductPageFactory.prototype.createBody = function () {
        return new Body();
    };
    ProductPageFactory.prototype.createFooter = function () {
        return new Footer();
    };
    ProductPageFactory.prototype.createHeader = function () {
        return new Header();
    };
    return ProductPageFactory;
}());
var PageCreater = /** @class */ (function () {
    function PageCreater() {
    }
    PageCreater.prototype.create = function (pageFactory) {
        return new Page(pageFactory.Title, pageFactory.createHeader(), pageFactory.createBody(), pageFactory.createFooter());
    };
    return PageCreater;
}());
var pageCreater = new PageCreater();
var homePage = pageCreater.create(new HomePageFactory());
console.log(homePage.title);
