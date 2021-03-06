﻿var webpackConfig = require('./webpack.qa');

module.exports = function(config) {
    const Config = {
        basePath: '',

        frameworks: ['jasmine'],

        files: [
            { pattern: './ClientApp/config/karma-test-shim.js', watched: false }
        ],

        preprocessors: {
            './ClientApp/config/karma-test-shim.js': ['webpack', 'sourcemap']
        },

        webpack: webpackConfig,

        webpackMiddleware: {
            stats: 'errors-only'
        },

        webpackServer: {
            noInfo: true
        },

        reporters: ['kjhtml'],
        port: 9876,
        colors: true,
        logLevel: config.LOG_VERBOSE,
        autoWatch: true,
        browsers: ['Opera'],
        singleRun: true
    };

    config.set(Config);
};