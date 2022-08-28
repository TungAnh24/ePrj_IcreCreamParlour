const btn = document.getElementsByClassName('btnOrderBook')

const products = []

for (var i = 0; i < btn.length; i++) {
    let cartBtn = btn[i]
    cartBtn.addEventListener('click', () => {
        let product = {
            // image: event.target.parentElement.parentElement.children[0].children[0].src,
            // name: event.target.parentElement.parentElement.children[1].children[0].textContent,
            // price: event.target.parentElement.parentElement.children[2].children[0].textContent,
            // totalPrice: parseInt(event.target.parentElement.parentElement.children[2].children[0].textContent) ,
            // quantity: 1
            imagebook: event.target.parentElement.parentElement.children[1].children[0].src,
            titlebook: event.target.parentElement.parentElement.children[2].children[0].textContent,
            pricebook: event.target.parentElement.parentElement.children[0].children[0].textContent,
            authorbook: event.target.parentElement.parentElement.children[3].children[0].textContent,
            totalPrice: parseInt(event.target.parentElement.parentElement.children[0].children[0].textContent),
            quantity: 1
        }

        addItemToLocal(product)
    })
}
function addItemToLocal(product) {
    let cartItem = JSON.parse(localStorage.getItem('prdInCart'))
    if (cartItem === null) {
        products.push(product)
        localStorage.setItem('prdInCart', JSON.stringify(products))

    } else {
        cartItem.forEach(item => {
            if (product.name == item.name) {
                product.quantity = item.quantity += 1;
                product.totalPrice = item.totalPrice += product.totalPrice;
            } else {
                products.push(item)
            }
        });
        products.push(product)
    }
    localStorage.setItem('prdInCart', JSON.stringify(products))
    window.location.reload()
}
function cartNumberDisplay() {
    let cartNumbers = 0;
    let cartItem = JSON.parse(localStorage.getItem('prdInCart'))
    cartItem.forEach(item => {
        cartNumbers = item.quantity += cartNumbers;
    });
    console.log(cartNumbers);
    document.querySelector('.navCart span').textContent = cartNumbers;
}
cartNumberDisplay()




function dispCartItem() {
    let html = '';
    let cartItem = JSON.parse(localStorage.getItem('prdInCart'))
    cartItem.forEach(item => {
        html += `
        <!--<div class="cartdisp">
            <div class="forImage">
                <img src="${item.imagebook}" alt="">
            </div>
            <div class="forName">
                <h3>${item.name}</h3>
            </div>
            <div class="forPrice">
                <h3>${item.price}</h3>
            </div>
            <div class="forQuantity">
                <h3>${item.quantity}</h3>
            </div>
            <div class="forTotal">
                <h3>${item.totalPrice}</h3>
            </div>
            <div class="reoveItem"><button>remove</button></div>
        </div>-->
        
            <div class="d-flex flex-row">
                <img class="rounded" src="${item.imagebook}" width="40">
                <div class="ml-2">
                    <span class="font-weight-bold d-block">${item.titlebook}</span>
                    <span class="spec">$${item.price}, ${item.price}</span>
                </div>
            </div>
            <div class="d-flex flex-row align-items-center">
                <span class="d-block">${item.quantity}</span>
                <span class="d-block ml-5 font-weight-bold">$${item.totalPrice}</span>
                <i class="fa fa-trash-o ml-3 text-black-50"></i>
            </div>
            <div class="reoveItem">
                <button>remove</button>
            </div>
    `
    });
    document.querySelector('.cartdisp').innerHTML = html;
}
dispCartItem()



const removeItem = document.getElementsByClassName('reoveItem')
for (var i = 0; i < removeItem.length; i++) {
    let removeBtn = removeItem[i]
    removeBtn.addEventListener('click', () => {
        let cartItem = JSON.parse(localStorage.getItem('prdInCart'))
        console.log(event.target.parentElement.parentElement.children[1].children[0].textContent);
        cartItem.forEach(item => {
            if (item.name != event.target.parentElement.parentElement.children[1].children[0].textContent) {
                products.push(item)
            }
        });
        localStorage.setItem('prdInCart', JSON.stringify(products))
        window.location.reload()
    })
}

function cartPrice() {
    let subTotal = 0;
    let cartItem = JSON.parse(localStorage.getItem('prdInCart'))
    cartItem.map(item => {
        subTotal = item.totalPrice += subTotal;

    })
    console.log(subTotal);
    document.querySelector('.priceView h2').textContent = subTotal
}
cartPrice()