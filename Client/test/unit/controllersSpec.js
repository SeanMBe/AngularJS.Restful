/* jasmine specs for controllers go here */

describe('ProductsCtrl', function(){
  var myCtrl1;

  beforeEach(function(){
    myCtrl1 = new ProductsCtrl();
  });


  it('should have expected products',  function() {
    expect(myCtrl1.products).toEqual([{id:1},{id:2},{id:3}]);
  });
});


describe('CartCtrl', function(){
  var myCtrl2;


  beforeEach(function(){
    myCtrl2 = new CartCtrl();
  });


  it('should ....', function() {
    //spec body
  });
});
