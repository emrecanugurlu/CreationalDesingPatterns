class Page{
    title : string
    header : Header
    body : Body
    footer : Footer
    constructor(title : string , header : Header, body : Body, footer :Footer  ) {
        this.title = title
        this.header = header
        this.body = body
        this.footer = footer
    }
}

class Header {

}
class Body {

}
class Footer {

}

interface PageFactory {
    createHeader() : Header
    createBody() : Body
    createFooter() : Footer
    Title : string
}
class HomePageFactory implements PageFactory{

    createBody(): Body {
        return new Body();
    }

    createFooter(): Footer {
        return new Footer();
    }

    createHeader(): Header {
        return new Header();
    }

    Title: string = "Home Page";

}
class ProductPageFactory implements PageFactory{
    createBody(): Body {
        return new Body();
    }

    createFooter(): Footer {
        return new Footer();
    }

    createHeader(): Header {
        return new Header();
    }

    Title: string = "Product Page";


}
class PageCreater{
    create(pageFactory : PageFactory) : Page{
        return new Page(pageFactory.Title,pageFactory.createHeader(),pageFactory.createBody(),pageFactory.createFooter())
    }
}

var pageCreater : PageCreater = new PageCreater()
var homePage : Page = pageCreater.create(new HomePageFactory())

console.log(homePage.title)