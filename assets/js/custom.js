$(document).ready(function() {
    "use strict";

    /*==================================
* Author        : "ThemeSine"
* Template Name : Furniture E- commarce HTML Template
* Version       : 1.0
==================================== */




    /*=========== TABLE OF CONTENTS ===========
    1. Scroll To Top 
    2. owl carousel
    3. welcome animation support
    4. cart close
    ======================================*/

    // 1. Scroll To Top 
    $(window).on('scroll', function() {
        if ($(this).scrollTop() > 600) {
            $('.return-to-top').fadeIn();
        } else {
            $('.return-to-top').fadeOut();
        }
    });
    $('.return-to-top').on('click', function() {
        $('html, body').animate({
            scrollTop: 0
        }, 1500);
        return false;
    });

});