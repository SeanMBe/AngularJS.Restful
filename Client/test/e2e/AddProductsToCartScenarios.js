describe('Adding Products to Cart', function() {

    beforeEach(function() {
        browser().navigateTo('../../app/index.html');
    });


    describe('When I add three of a product to cart', function() {

        beforeEach(function() {
            browser().navigateTo('#/products');
        });


        it('should have three of that product in my cart', function() {
            //<li class="ng-attr-widget" ng:repeat-index="1">

//ng\\:repeat-index="1
            element('.ng-attr-widget:nth-child(2) input').val('3');
            element('.ng-attr-widget:nth-child(2) button').click();
            browser().navigateTo('#/cart');
            expect(element(':input').val()).toEqual('3');
        });
    });
});
