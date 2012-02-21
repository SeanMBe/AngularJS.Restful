describe('When I add products to cart', function() {

    beforeEach(function() {
        browser().navigateTo('../../app/index.html');
    });

    it('should have three of that product in my cart', function() {
        element('.ng-attr-widget:nth-child(2) input').val('3');
        element('.ng-attr-widget:nth-child(2) button').click();
        browser().navigateTo('#/cart');
        expect(element(':input').val()).toEqual('3');
    });

    it('should have six of that product in my cart when I add twice', function() {
        element('.ng-attr-widget:nth-child(2) input').val('3');
        element('.ng-attr-widget:nth-child(2) button').click();
        element('.ng-attr-widget:nth-child(2) button').click();
        browser().navigateTo('#/cart');
        expect(element(':input').val()).toEqual('6');
    });
});
