"use strict";

var gulp = require('gulp');
var _ = require('lodash');

gulp.task("copy-assets", function () {
    var assets = {
        moment: ['./node_modules/moment/min/*.js']
    };
    _(assets).forEach(function (assets, type) {
        gulp.src(assets).pipe(gulp.dest('./wwwroot/lib/node_modules/' + type));
    });
});