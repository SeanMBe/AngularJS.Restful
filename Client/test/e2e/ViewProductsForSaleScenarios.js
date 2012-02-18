describe('e commerce app', function() {

  beforeEach(function() {
    browser().navigateTo('../../app/index.html');
  });


  it('should automatically redirect to /products when location hash/fragment is empty', function() {
    expect(browser().location().hash()).toBe("/products");
  });


  describe('Products View', function() {

    beforeEach(function() {
      browser().navigateTo('#/products');
    });


    it('should render products for sale when user navigates to /products', function() {
      expect(element('ng\\:view p:first').text()).
        toMatch(/These products are for sale/);
    });

    it('should have 3 items for sale', function() {

        expect(repeater('.products li').count()).toBe(3);
    });

  });


  describe('Cart', function() {

    beforeEach(function() {
      browser().navigateTo('#/cart');
    });


    it('should render view1 when user navigates to /view2', function() {
      expect(element('ng\\:view p:first').text()).
        toMatch(/partial for view 2/);
    });

  });
});
