(function () {
  var registerService = function () {

  };

  var controller = function () {
    var self = this;

    self.submit = function () {
      console.log(this.model);
    }
  };

  addAngularState('register', '/register', 'Register', controller, '');
})();


