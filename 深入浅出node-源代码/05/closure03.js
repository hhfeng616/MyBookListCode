var foo = function () {
  var bar = function () {
    var local = "ć±éšćé";
    return function () {
      return local;
    };
  };
  var baz = bar();
  console.log(baz());
};
foo();
