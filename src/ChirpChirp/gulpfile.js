// include plug-ins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');
var wiredep = require('wiredep').stream;

var paths = {
  build: 'wwwroot/build',
  indexView: 'Views/Home/index.cshtml',
  index: 'wwwroot/build/index.cshtml',
  bower: {
    json: require('./bower.json'),
    directory: 'wwwroot/bower_components'
  },
}

var config = {
  src: ['app/**/*.js', '!app/**/*.min.js']
}

gulp.task('index', function () {
  return gulp.src(paths.indexView)
             .pipe(gulp.dest(paths.build));
})

gulp.task('clean', [], function (callback) {
  return del.sync([paths.build], callback);
});

gulp.task('scripts', [], function () {
  return gulp.src(config.src)
    .pipe(concat('build.min.js'))
    .pipe(gulp.dest(paths.build));
});

gulp.task('libraries', ['scripts', 'index'], function () {
  var options = {
    bowerJson: paths.bower.json,
    directory: paths.bower.directory,
    src: paths.index
  };

  return gulp.src(paths.index)
             .pipe(wiredep(options))
             .pipe(gulp.dest(paths.build));
});

gulp.task('watch', [], function () {
  return gulp.watch(config.src, ['scripts']);
});

//Set a default tasks
gulp.task('default', ['clean', 'scripts', 'index', 'libraries'], function () { });