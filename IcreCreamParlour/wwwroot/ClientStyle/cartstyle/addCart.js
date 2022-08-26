
    const addCart = document.querySelectorAll('#addCart');
    const cartShow = document.querySelector('#navbarMenu span');
    console.log(addCart);
    for (var i = 0; i < addCart.length; i++) {
        addCart[i].addEventListener('click', () => {
            cartCount();
        })
    }
    function cartCount() {
        let prdCount = localStorage.getItem('cartsCount');
    prdCount = parseInt(parse);
    if (prdCount) {
        localStorage.setItem('cartsCount', prdCount + 1);
    cartShow.textContent = prdCount + 1;
        } else {
        localStorage.setItem('cartsCount', 1);
    cartShow.textContent = prdCount = 1;
        }
    }