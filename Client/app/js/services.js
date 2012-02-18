/* http://docs.angularjs.org/#!angular.service */

/**
 * App service which is responsible for the main configuration of the app.
 */
angular.service('myAngularApp', function($route, $location, $window) {

  $route.when('/products', {template: 'partials/products.html', controller: ProductsCtrl});
  $route.when('/cart', {template: 'partials/cart.html', controller: CartCtrl});

  var self = this;

  $route.onChange(function() {
    if ($location.hash === '') {
      $location.updateHash('/products');
      self.$eval();
    } else {
      $route.current.scope.params = $route.current.params;
      $window.scrollTo(0,0);
    }
  });

}, {$inject:['$route', '$location', '$window'], $eager: true});
