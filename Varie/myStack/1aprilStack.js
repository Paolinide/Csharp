<!DOCTYPE html>


    <html itemscope itemtype="http://schema.org/QAPage" class="html__responsive">

    <head>

        <title>Including JavaScript class definition from another file in Node.js - Stack Overflow</title>
        <link rel="shortcut icon" href="https://cdn.sstatic.net/Sites/stackoverflow/img/favicon.ico?v=4f32ecc8f43d">
        <link rel="apple-touch-icon image_src" href="https://cdn.sstatic.net/Sites/stackoverflow/img/apple-touch-icon.png?v=c78bd457575a">
        <link rel="search" type="application/opensearchdescription+xml" title="Stack Overflow" href="/opensearch.xml">
        <meta name="viewport" content="width=device-width, height=device-height, initial-scale=1.0, minimum-scale=1.0">


        <meta property="og:type" content= "website" />
        <meta property="og:url" content="https://stackoverflow.com/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js"/>
        <meta property="og:site_name" content="Stack Overflow" />
        <meta property="og:image" itemprop="image primaryImageOfPage" content="https://cdn.sstatic.net/Sites/stackoverflow/img/apple-touch-icon@2.png?v=73d79a89bded" />
        <meta name="twitter:card" content="summary"/>
        <meta name="twitter:domain" content="stackoverflow.com"/>
        <meta name="twitter:title" property="og:title" itemprop="name" content="Including JavaScript class definition from another file in Node.js" />
        <meta name="twitter:description" property="og:description" itemprop="description" content="I&#39;m writing a simple server for Node.js and I&#39;m using my own class called User which looks like:

function User(socket) {
    this.socket = socket;
    this.nickname = null;

    /* ... just the ty..." />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
        <script src="https://cdn.sstatic.net/Js/stub.en.js?v=bc12cb1b3982"></script>
    
    <link rel="stylesheet" type="text/css" href="https://cdn.sstatic.net/Shared/stacks.css?v=58428843e325" >
    <link rel="stylesheet" type="text/css" href="https://cdn.sstatic.net/Sites/stackoverflow/primary.css?v=2475bbf3f6fc" >

    
            <link rel="alternate" type="application/atom+xml" title="Feed for question &#39;Including JavaScript class definition from another file in Node.js&#39;" href="/feeds/question/6998355">
            <meta name="twitter:app:country" content="US" />
            <meta name="twitter:app:name:iphone" content="Stack Exchange iOS" />
            <meta name="twitter:app:id:iphone" content="871299723" />
            <meta name="twitter:app:url:iphone" content="se-zaphod://stackoverflow.com/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js" />
            <meta name="twitter:app:name:ipad" content="Stack Exchange iOS" />
            <meta name="twitter:app:id:ipad" content="871299723" />
            <meta name="twitter:app:url:ipad" content="se-zaphod://stackoverflow.com/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js" />
            <meta name="twitter:app:name:googleplay" content="Stack Exchange Android">
            <meta name="twitter:app:url:googleplay" content="http://stackoverflow.com/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js">
            <meta name="twitter:app:id:googleplay" content="com.stackexchange.marvin">
        <script>

            StackExchange.ready(function () {
                                    
                    StackExchange.using("snippets", function () {
                        StackExchange.snippets.initSnippetRenderer();
                    });
                    

                StackExchange.using("postValidation", function () {
                    StackExchange.postValidation.initOnBlurAndSubmit($('#post-form'), 2, 'answer');
                });

                
                StackExchange.question.init({showAnswerHelp:true,totalCommentCount:0,shownCommentCount:0,highlightColor:'#F4A83D',backgroundColor:'#FFF',questionId:6998355});

                styleCode();

                    StackExchange.realtime.subscribeToQuestion('1', '6998355');
                                                    StackExchange.using("gps", function () { StackExchange.gps.trackOutboundClicks('#content', '.post-text'); });

            });
        </script>
            <style>
            .js-toggle-container {
                display: inline-flex !important;
            }
        </style>
        <script>
            StackExchange.ready(function () {
                $(".js-time-machine-button").click(function (e) {
                    e.preventDefault();

                    if ($.cookie("tm2019") !== null) {
                        $.cookie("tm2019", null, { path: '/', expires: -1 });
                        $.cookie("tm2019d", null, { path: '/', expires: -1 });
                    } else {
                        $.cookie("tm2019", "1", { path: '/', expires: 2 });
                    }

                    window.location.reload(false); 
                })
            })
        </script>
        <!--
                        HAPPY APRIL FOOL'S FROM STACK OVERFLOW

                      \/                    __/   .::::.-'-(/-/)
                             _/:  .::::.-' .-'\/\_`*******          __ (_))
                \/          /:  .::::./   -._-.  d\|               (_))_(__))
                             /: (""""/    '.  (__/||           (_))__(_))--(__))
                              \::).-'  -._  \/ \\/\|
                      __ _ .-'`)/  '-'. . '. |  (i_O
                  .-'      \       -'      '\|
             _ _./      .-'|       '.  (    \\                         % % %
          .-'   :      '_  \         '-'\  /|/      @ @ @             % % % %
         /      )\_      '- )_________.-|_/^\      @ @ @@@           % %\/% %
         (   .-'   )-._-:  /        \(/\'-._ `.     @|@@@@            ..|........
          (   )  _//_/|:  /          `\()   `\_\     |/_@@             )'-._.-._.-
           ( (   \()^_/)_/             )/      \\    /                /   /
            )  _.-\\.\(_)__._.-'-.-'-.//_.-'-.-.)\-'/._              /
        .-.-.-'   _o\ \\\     '::'   (o_ '-.-' |__\'-.-;~ ~ ~ ~ ~ ~~/   /\
                  \ /  \\\__          )_\    .:::::::.-'\          '- - -|
             :::''':::::^)__\:::::::::::::::::'''''''-.  \                '- - -
            :::::::  '''''''''''   ''''''''''''':::. -'\  \     C. SWANSIGER
        _____':::::_____________________________________\__\______________________
        -->
        <style>
            

            .ff-comic {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif !important;
            }

            .ff-times {
                font-family: 'Times New Roman', Times, serif !important;
            }

            .fc-fuschia {
                color: #9013FE !important;
            }

            

            body {
                background-image: url("https://cdn.sstatic.net/Img/april-fools-2019/so-tile.png?v=5922b5fd7715");
                font-family: 'Times New Roman', Times, serif;
            }

            #content {
                border-width: 0 4px 0px 4px; 
                border-style: solid;
                border-color: #32E830;
            }

            .container h2, .container h4, .bulletin-title {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
                color: #9013FE !important;
            }
            
            .container h5 {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
                font-style: uppercase;
            }

            .container .bulletin-item-content a {
                text-decoration: underline;
            }
            
            .container .favicon {
                background-image: url("https://cdn.sstatic.net/Img/april-fools-2019/broken-image.png?v=a2722a3b4e69");
                background-position: 0px;
            }

            .tm-unicorn-front {
                position: absolute;
                top: 200px;
                left: -195px;
            }

            .tm-unicorn-back {
                position: absolute;
                top: 330px;
                right: -198px;
            }

            @media  (max-width: 1700px) {
                .tm-unicorn-front, .tm-unicorn-back {
                    display: none;
                }
            }

            

            .tm-toggle {
                width: 20px;
                height: 20px;
            }

            

            #question-header .question-hyperlink {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
                text-decoration: none;
            }

            #question-header a.s-btn {
                border-radius: 0;
                background: blue;
                color: #fff;
                text-decoration: none;
                border: 3px outset blue;
                cursor: pointer;
            }

            .question-hyperlink {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
            }

            

            #tm-header {
                border-bottom: 4px solid #32E830;
            }

            #tm-scroll {
                -moz-transform: translateX(100%);
                -webkit-transform: translateX(100%);	
                transform: translateX(100%);
                -moz-animation: marquee 15s linear infinite;
                -webkit-animation: marquee 15s linear infinite;
                animation: marquee 15s linear infinite;
            }

            
            @-moz-keyframes marquee {
                0%   { -moz-transform: translateX(100%); }
                100% { -moz-transform: translateX(-100%); }
            }
            @-webkit-keyframes marquee {
                0%   { -webkit-transform: translateX(100%); }
                100% { -webkit-transform: translateX(-100%); }
            }
            @keyframes marquee {
                0% { 
                    -moz-transform: translateX(100%); 
                    -webkit-transform: translateX(100%); 
                    transform: translateX(100%); 		
                }
                100% { 
                    -moz-transform: translateX(-100%); 
                    -webkit-transform: translateX(-100%); 
                    transform: translateX(-100%); 
                }
            }

            

            #left-sidebar {
                background: linear-gradient(0deg, #4395CF 0%, #9A54E3 100%);
                border-left: 4px solid #32E830;
            }

            #left-sidebar a {;
                color: #F8E71C;
                text-decoration: underline;
            }

            #left-sidebar li, .fc-medium {
                color: #fff !important;
            }

            .tm-globe {
                width: 15px;
                height: 15px;
                margin-right: 5px;
            }

            

            #mainbar a {
                color: blue;
                text-decoration: underline;
            }

            .post-text {
                font-family: 'Times New Roman', Times, serif;
            }

            .user-details, .comment-copy, .post-tag {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
            }

            .question-page #answers .answer, .wmd-container {
                border: 5px groove;
            }

            #wmd-preview {
                font-family: "Comic Sans MS", "Comic Sans", cursive, sans-serif;
            }

             

            .community-bulletin {
                border: 5px groove #EDE8E7 !important;
            }

            #tm-views {
                display: inline-block;
                background: #000;
                color: #7FFF00;
                padding: 5px 0px 5px 5px;
                letter-spacing: 5px;
                font-weight: bold;
                font-family: "Consolas";
            }
            
            .tm-fire {
                width: 15px;
                height: 20px;
            }

            

            #tm-footer {
                background-image: url("https://cdn.sstatic.net/Img/april-fools-2019/guestbook-tile.png?v=a3115b974309");
            }

            #tm-footer-top {
                background-image: url("https://cdn.sstatic.net/Img/april-fools-2019/pencil-border.png?v=16dd39c85511");
                height: 30px;
                margin-bottom: 75px;
            }

            #tm-footer-bottom {
                background-image: url("https://cdn.sstatic.net/Img/april-fools-2019/footer-border.gif?v=2f26a0868ebf");
                height: 30px;
                margin-top: 75px;
            }

            .tm-form-container {
                background: #9013FE;
                border: 3px inset #fcfcfc;
            }

            .tm-comments {
                border: 3px inset #fcfcfc;
                height: 350px;
            }

            .tm-comment-input {
                height: 150px;
            }

            #tm-guestbook input, #tm-guestbook textarea {
                width: 100%;
            }

            

            .site-footer .-link {
                text-decoration: underline;
            }
        </style>
        <script>
            StackExchange.ready(function () {

                injectMarkup();
                initSidebar();
                initGuestbook();
                initPopover();

                function injectMarkup() {
                    if ($("#content").css('backgroundColor') === 'rgba(0, 0, 0, 0)' && $("body").css('backgroundColor') !== 'rgba(0, 0, 0, 0)') {
                        $("#content").css('backgroundColor', $("body").css('backgroundColor'));
                    }

                    // Header
                    var _h = '';
                    _h += '<div id="tm-header" class="bg-black-900 ta-center py24 overflow-hidden">';
                        _h += '<div id="tm-scroll">';
                           _h += '<img src="https://cdn.sstatic.net/Img/april-fools-2019/headline.gif?v=f81430a4e488" alt="Welcome to Stack Overflow" />';
                        _h += '</div>';
                    _h += '</div>';
                    $("body").prepend(_h);

                    // Unicorns?
                    $("#left-sidebar").prepend('<img class="tm-unicorn-front" src="https://cdn.sstatic.net/Img/april-fools-2019/unicorn-front-half.png?v=3b572eca29f8" alt="UNI..."/>');
                    $(".container").append('<img class="tm-unicorn-back" src="https://cdn.sstatic.net/Img/april-fools-2019/unicorn-back-half.png?v=1a044240263b" alt="...CORN"/>');

                    // Left sidebar link
                    var _l = '';
                    _l += '<div class="w100 ta-center fc-white ff-comic mt32">';
                        _l += '<img class="w100 mb24" src="https://cdn.sstatic.net/Img/april-fools-2019/caution-tape.png?v=e922b1b2376d" />';
                        _l += '<p class="tt-uppercase fw-bold fs3 mb24">~Under Construction~</p>';
                        _l += '<p class="mb0">Big changes for Y2K!</p>';
                        _l += '<a href="#" class="js-tm-sidebar-toggle s-btn s-btn__primary d-inline-block fc-white td-none mt24">Go to the future</a>';
                        _l += '<img class="w100 mt24" src="https://cdn.sstatic.net/Img/april-fools-2019/caution-tape.png?v=e922b1b2376d" />';
                    _l += '</div>';
                    $("#left-sidebar nav").append(_l);

                    var _f = ''; // Injected footer
                    _f += '<div id="tm-footer">';
                        _f += '<div id="tm-footer-top"></div>';
                        _f += '<h1 class="ta-center"><img class="wmx100" src="https://cdn.sstatic.net/Img/april-fools-2019/guestbook.png?v=af7ae3191a68" alt="Guestbook"></h1>';
                        _f += '<div class="grid mx-auto wmx8 ff-comic fc-white md:fd-column">';
                            _f += '<div class="js-tm-form-container tm-form-container grid--cell5 grid--cell12 p12 fc-white">';
                                _f += '<form id="js-tm-form">';
                                    _f += '<p class="mb4"><label for="guestbook-name">Name:</label></p>';
                                    _f += '<input class="js-tm-name-input mb16 w100" type="text" name="guestbook-name" required />';
                                    _f += '<p class="mb4"><label for="guestbook-name">Comment:</label></p>';
                                    _f += '<textarea class="js-tm-comment-input w100 hs1 mb16" name="guestbook-comment" required></textarea>';
                                    _f += '<input id="js-tm-submit" class="w100" type="submit" value="Sign our guestbook!" />';
                                _f += '</form>';
                            _f += '</div>';
                            _f += '<div class="js-tm-comments tm-comments grid--cell7 grid--cell12 p12 overflow-y-scroll bg-white">';
                            _f += '</div>';
                        _f += '</div>';
                        _f += '<div id="tm-footer-bottom"></div>';
                    _f += '</div>';
                    $("#footer").prepend(_f);

                    // Site footer
                    $(".site-footer--copyright p")
                        .before('<p class="fw-bold fc-white mb0 ff-comic fs-body1">Proudly built in Notepad</p>')
                        .after('<p class="fw-bold fc-white ff-comic tt-uppercase fs-body1">Best viewed in <img class="d-inline-block" src="https://cdn.sstatic.net/Img/april-fools-2019/netscape-badge.png?v=090cdcefe523" alt="Netscape 3.0"></p>');


                    // Gif injections
                    var globe = '<img src="https://cdn.sstatic.net/Img/april-fools-2019/globe.gif?v=d8211e5aae84" class="tm-globe" />';
                    $("svg.svg-icon.iconGlobe").before(globe).remove();

                    var $hnqHeadline = $("#hot-network-questions h4");
                    if ($hnqHeadline.length) {
                        var flame = '<img src="https://cdn.sstatic.net/Img/april-fools-2019/fire.gif?v=a3a5393ce037" class="tm-fire" />';
                        $hnqHeadline.append(flame).prepend(flame);
                    }
                }

                function initSidebar() {
                    $(".js-tm-sidebar-toggle").click(function (e) {
                        e.preventDefault();

                        $.cookie("tm2019", "1", { path: '/', expires: 2 });

                        window.location.reload(false);
                    })
                }

                function initGuestbook() {
                    populateGuestbook();
                    bindGuestbook();

                    // Randomly add items
                    setInterval(function () {
                        if (Math.floor(Math.random() * 3) === 0) {
                            addRandomComment();
                        }
                    }, 300);
                }

                function initPopover() {
                    var $popover = $(".js-toggle-popover");
                    setTimeout(function () {
                        $popover.insertBefore(".js-time-machine-button").removeClass("d-none").addClass("is-visible");
                    }, 1000 * 4);

                    $(document).on("click touchstart", ".js-time-machine-button, .js-toggle-popover-close", function () {
                        $popover.remove();
                        $.cookie("tm2019d", "1", { path: '/', expires: 2 });
                    });
                }

                function populateGuestbook() {
                    for (var i = 0; i < 10; i++) {
                        addRandomComment();
                    }
                }

                function bindGuestbook() {
                    $("#js-tm-form").submit(function (e) {
                        e.preventDefault();

                        var $name = $(".js-tm-name-input");
                        var $comment = $(".js-tm-comment-input");

                        if ($name.val().length === 0 || $comment.val().length === 0) return;

                        addComment($name.val(), $comment.val());

                        $name.val(null);
                        $comment.val(null);
                    })
                }

                function addRandomComment() {
                    var names = [
                        "adam",
                        "jane",
                        "meg",
                        "jon",
                        "josh",
                        "lisa",
                        "brian"
                    ];
                    var comments = [
                        "Is this an April Fool's joke?",
                        "this is for april 1",
                        "april fools :)",
                        "Where's the webring? :(",
                        "check out this song! http://myspace.com/soeb__42345",
                        "FIIIIIIIRRRSSSSTTTTTTT",
                        "...",
                        "lol",
                        "lol jk",
                        "testing.",
                        "the unicorns are genius",
                        "did they kill sparkles???",
                        "fireballs would have been better",
                        "I forgot about <marquee> lol",
                        "<marquee> !!!",
                        "What about <blink>?",
                        "testing...",
                        "test test test",
                        "does this wor",
                        "OMG HAHAHA",
                        "omg",
                        "heh.",
                        "hehehe",
                        "I think they got haxxxed",
                        "There are so many better things for the devs to do.",
                        "I guess it's April :P",
                        "f",
                        "it's almost Y2K!!!",
                        "what browser are you using?",
                        "netscape 4.05",
                        "ff",
                        "DHTML!",
                        "Flash"
                    ];

                    addComment(names[Math.floor(Math.random()*names.length)], comments[Math.floor(Math.random()*comments.length)])
                }

                function escapeHtml(text) {
                    var map = {
                        '&': '&amp;',
                        '<': '&lt;',
                        '>': '&gt;',
                        '"': '&quot;',
                        "'": '&#039;'
                    };

                    return text.replace(/[&<>"']/g, function(m) { return map[m]; });
                }

                function addComment(name, comment) {

                    var content = '<div class="ff-comic fc-fuschia bb bbw2 bc-black-3 fs-body3 p12">';
                        content += '<p class="mb4">' + escapeHtml(comment) + '</p>';
                        content += '<p class="tm-comment-info ff-times fs-caption">@' + escapeHtml(name) + ' - 2019/04/01</p>'
                    content += '</div>';

                    $(".js-tm-comments").prepend(content);
                }

                /*!
             * Fairy Dust Cursor.js
             * - 90's cursors collection
             * -- https://github.com/tholman/90s-cursor-effects
             * -- https://codepen.io/tholman/full/jWmZxZ/
             */

                (function fairyDustCursor() {

                  var possibleColors = ["#D61C59", "#E7D84B", "#1B8798"]
                  var width = window.innerWidth;
                  var height = window.innerHeight;
                  var cursor = {x: width/2, y: width/2};
                  var particles = [];

                  function init() {
                    bindEvents();
                    loop();
                  }

                  // Bind events that are needed
                  function bindEvents() {
                      document.addEventListener('mousemove', onMouseMove);
                      window.addEventListener('resize', onWindowResize);
                  }

                  function onWindowResize(e) {
                    width = window.innerWidth;
                    height = window.innerHeight;
                  }

                  function onMouseMove(e) {
                    cursor.x = e.clientX;
                    cursor.y = e.clientY;

                    addParticle( cursor.x, cursor.y, possibleColors[Math.floor(Math.random()*possibleColors.length)]);
                  }

                  function addParticle(x, y, color) {
                    var particle = new Particle();
                    particle.init(x, y, color);
                    particles.push(particle);
                  }

                  function updateParticles() {

                    // Updated
                    for( var i = 0; i < particles.length; i++ ) {
                      particles[i].update();
                    }

                    // Remove dead particles
                    for( var i = particles.length -1; i >= 0; i-- ) {
                      if( particles[i].lifeSpan < 0 ) {
                        particles[i].die();
                        particles.splice(i, 1);
                      }
                    }

                  }

                  function loop() {
                    requestAnimationFrame(loop);
                    updateParticles();
                  }

                  /**
                   * Particles
                   */

                  function Particle() {

                    this.character = "*";
                    this.lifeSpan = 120; //ms
                    this.initialStyles ={
                      "position": "fixed",
                      "display": "inline-block",
                      "top": "0px",
                      "left": "0px",
                      "pointerEvents": "none",
                      "touch-action": "none",
                      "z-index": "10000000",
                      "fontSize": "25px",
                      "will-change": "transform"
                    };

                    // Init, and set properties
                    this.init = function(x, y, color) {

                      this.velocity = {
                        x:  (Math.random() < 0.5 ? -1 : 1) * (Math.random() / 2),
                        y: 1
                      };

                      this.position = {x: x + 10, y: y + 10};
                      this.initialStyles.color = color;

                      this.element = document.createElement('span');
                      this.element.innerHTML = this.character;
                      applyProperties(this.element, this.initialStyles);
                      this.update();

                      document.querySelector('.js-cursor-container').appendChild(this.element);
                    };

                    this.update = function() {
                      this.position.x += this.velocity.x;
                      this.position.y += this.velocity.y;
                      this.lifeSpan--;

                      this.element.style.transform = "translate3d(" + this.position.x + "px," + this.position.y + "px, 0) scale(" + (this.lifeSpan / 120) + ")";
                    }

                      this.die = function () {
                            this.element.parentNode.removeChild(this.element);
                    }

                  }

                  /**
                   * Utils
                   */

                  // Applies css `properties` to an element.
                  function applyProperties( target, properties ) {
                    for( var key in properties ) {
                      target.style[ key ] = properties[ key ];
                    }
                  }

                  if (!('ontouchstart' in window || navigator.msMaxTouchPoints)) init();
                })();
            });
        </script>

        
        
        
        
        
        


        <script>
        StackExchange.init({"locale":"en","serverTime":1554047176,"routeName":"Questions/Show","stackAuthUrl":"https://stackauth.com","networkMetaHostname":"meta.stackexchange.com","site":{"name":"Stack Overflow","description":"Q&A for professional and enthusiast programmers","isNoticesTabEnabled":true,"enableNewTagCreationWarning":true,"insertSpaceAfterNameTabCompletion":false,"id":1,"childUrl":"https://meta.stackoverflow.com","enableSocialMediaInSharePopup":true,"protocol":"https"},"user":{"fkey":"cc776723d6fbd4b216f0f3b71598dcbe5e4f247dee506bb825bc1c894126e9e2","tid":"e87eac01-7a43-e7bf-e60f-35390ed250a4","rep":0,"isAnonymous":true,"isAnonymousNetworkWide":true,"ab":{"inline_signup_hero":{"v":"d","g":1}}},"events":{"postType":{"question":1},"postEditionSection":{"title":1,"body":2,"tags":3}},"story":{"minCompleteBodyLength":75,"likedTagsMaxLength":300,"dislikedTagsMaxLength":300},"jobPreferences":{"maxNumDeveloperRoles":2,"maxNumIndustries":4},"svgIconPath":"https://cdn.sstatic.net/Img/svg-icons","svgIconHash":"6e41a6bc8765"}, {"userProfile":{"openGraphAPIKey":"58740831ad23540e00c58987"},"userMessaging":{},"tags":{},"snippets":{"snippetsEnabled":true,"renderDomain":"stacksnippets.net"},"slack":{"sidebarAdDismissCookie":"slack-sidebar-ad"},"site":{"allowImageUploads":true,"enableUserHovercards":true,"styleCode":true,"enableImgurHttps":true,"forceHttpsImages":true},"paths":{},"monitoring":{"clientTimingsAbsoluteTimeout":30000,"clientTimingsDebounceTimeout":1000},"mentions":{"maxNumUsersInDropdown":50},"markdown":{"asteriskIntraWordEmphasis":true},"flags":{"allowRetractingFlags":true},"comments":{},"accounts":{"currentPasswordRequiredForChangingStackIdPassword":true}});
        StackExchange.using.setCacheBreakers({"js/prettify-full.en.js":"4df298744d75","js/moderator.en.js":"ce6e5aa16ed3","js/pseudomoderator.en.js":"81279009c185","js/full-anon.en.js":"aeaa2fbcbe7b","js/full.en.js":"bf108e20f107","js/wmd.en.js":"1cbcc7b37411","js/mobile.en.js":"30ceeb5f5bf6","js/help.en.js":"cd8ecef60912","js/tageditor.en.js":"ec95a85b7232","js/tageditornew.en.js":"6beb9d83cc66","js/inline-tag-editing.en.js":"db88f48821d3","js/revisions.en.js":"297d702fb157","js/review.en.js":"fedefe051174","js/tagsuggestions.en.js":"78eee7c19ab2","js/post-validation.en.js":"e0142911a3c2","js/explore-qlist.en.js":"cd6e5274146c","js/events.en.js":"1112ba1b63d1","js/keyboard-shortcuts.en.js":"f02b0278bfef","js/external-editor.en.js":"6385aa552165","js/adops.en.js":"22a9bd59b1e9","js/begin-edit-event.en.js":"a03fb3ec532c","js/stacks-polyfills.en.js":"d11cdd76c40e","js/external-editor.en.js":"6385aa552165","js/snippet-javascript.en.js":"c0d1f6c0cc9a","js/snippet-javascript-codemirror.en.js":"457035237187"});
        StackExchange.using("gps", function() {
             StackExchange.gps.init(true);
        });
    </script>
    <noscript id="noscript-css"><style>body,.top-bar{margin-top:1.9em}</style></noscript>
    </head>
        <body class="question-page unified-theme">
    <div id="notify-container"></div>
    <div id="custom-header"></div>




<header class="top-bar js-top-bar top-bar__network _fixed">
    <div class="-container">
        <div class="-main">
                <a href="#" class="left-sidebar-toggle p0 ai-center jc-center js-left-sidebar-toggle"><span class="ps-relative"></span></a>
                                <a href="https://stackoverflow.com" class="-logo js-gps-track"
                        data-gps-track="top_nav.click({is_current:false, location:2, destination:8})">
                        <span class="-img _glyph">Stack Overflow</span>
                    </a>



        </div>

            <form id="search" action=/search method="get" class="searchbar js-searchbar " autocomplete="off" role="search">
                    <div class="ps-relative">
                        <input name="q" type="text" placeholder="Search…" value="" autocomplete="off" maxlength="240" class="s-input js-search-field " />
                        <button type="submit" aria-label="Search…" class="s-btn s-btn__primary s-btn__icon btn-topbar-primary js-search-submit"><svg aria-hidden="true" class="svg-icon iconSearch" width="18" height="18" viewBox="0 0 18 18"><path d="M12.86 11.32L18 16.5 16.5 18l-5.18-5.14v-.35a7 7 0 1 1 1.19-1.19h.35zM7 12A5 5 0 1 0 7 2a5 5 0 0 0 0 10z"/></svg></button>
                    </div>
            </form>

        






<ol class="-secondary js-secondary-topbar-links drop-icons-responsively user-logged-out">
        <li class="-item searchbar-trigger js-searchbar-trigger"><a href="#" class="-link"><svg aria-hidden="true" class="svg-icon iconSearch" width="18" height="18" viewBox="0 0 18 18"><path d="M12.86 11.32L18 16.5 16.5 18l-5.18-5.14v-.35a7 7 0 1 1 1.19-1.19h.35zM7 12A5 5 0 1 0 7 2a5 5 0 0 0 0 10z"/></svg></a></li>
            <li class="js-toggle-container -item d-none">
        <a href="#" class="js-time-machine-button -link" title="Time travel!">
            <svg aria-hidden="true" class="svg-icon tm-toggle iconClock" width="18" height="18" viewBox="0 0 18 18"><path d="M9 17A8 8 0 1 1 9 1a8 8 0 0 1 0 16zm0-2A6 6 0 1 0 9 3a6 6 0 0 0 0 12zM8 5h1.01L9 9.36l3.22 2.1-.6.93L8 10V5z"/></svg>
        </a>
    </li>
        <li class="-item inbox-button-item" data-remove-order=1>
        <a href="https://stackexchange.com/users/?tab=inbox" class="-link js-inbox-button" title="Recent inbox messages">
            <svg aria-hidden="true" class="svg-icon iconInbox" width="20" height="18" viewBox="0 0 20 18"><path d="M15.19 1H4.63c-.85 0-1.6.54-1.85 1.35L0 10.79V15c0 1.1.9 2 2 2h16a2 2 0 0 0 2-2v-4.21l-2.87-8.44A2 2 0 0 0 15.19 1zm-.28 10l-2 2h-6l-2-2H1.96L4.4 3.68A1 1 0 0 1 5.35 3h9.12a1 1 0 0 1 .95.68L17.86 11h-2.95z"/></svg>
            <span class="indicator-badge js-unread-count _important" style="display: none;"></span>
        </a>
    </li>
    <li class="-item achievements-button-item" data-remove-order=2>
        <a href="https://stackexchange.com/users/?tab=reputation" class="-link js-achievements-button" title="Recent achievements: reputation, badges, and privileges earned" data-unread-class="_highlighted-positive">
            <svg aria-hidden="true" class="svg-icon iconAchievements" width="18" height="18" viewBox="0 0 18 18"><path d="M15 2V1H3v1H0v4c0 1.6 1.4 3 3 3v1c.4 1.5 3 2.6 5 3v2H5s-1 1.5-1 2h10c0-.4-1-2-1-2h-3v-2c2-.4 4.6-1.5 5-3V9c1.6-.2 3-1.4 3-3V2h-3zM3 7c-.5 0-1-.5-1-1V4h1v3zm8.4 2.5L9 8 6.6 9.4l1-2.7L5 5h3l1-2.7L10 5h2.8l-2.3 1.8 1 2.7h-.1zM16 6c0 .5-.5 1-1 1V4h1v2z"/></svg>
            <span class="indicator-badge js-unread-count _positive" style="display: none;"></span>
        </a>
    </li>

    <li class="-item help-button-item"><a href="#" class="-link js-help-button" title="Help Center and other resources">
        <svg aria-hidden="true" class="svg-icon iconHelp" width="18" height="18" viewBox="0 0 18 18"><path d="M9 1a8 8 0 1 0 0 16A8 8 0 0 0 9 1zm.81 12.13c-.02.71-.55 1.15-1.24 1.13-.66-.02-1.17-.49-1.15-1.2.02-.72.56-1.18 1.22-1.16.7.03 1.2.51 1.17 1.23zM11.77 8a5.8 5.8 0 0 1-1.02.91l-.53.37c-.26.2-.42.43-.5.69a4 4 0 0 0-.09.75c0 .05-.03.16-.18.16H7.88c-.16 0-.18-.1-.18-.15.03-.66.12-1.21.4-1.66a5.29 5.29 0 0 1 1.43-1.22c.16-.12.28-.25.38-.39a1.34 1.34 0 0 0 .02-1.71c-.24-.31-.51-.46-1.03-.46-.51 0-.8.26-1.02.6-.21.33-.18.73-.18 1.1H5.75c0-1.38.35-2.25 1.1-2.76.52-.35 1.17-.5 1.93-.5 1 0 1.79.18 2.49.71.64.5.98 1.18.98 2.12 0 .57-.2 1.05-.48 1.44z"/></svg>
    </a></li>

    <li class="-item site-switcher-item">
        <a href="https://stackexchange.com" class="-link js-site-switcher-button js-gps-track" data-gps-track="site_switcher.show" title="A list of all 175 Stack Exchange sites">
            <svg aria-hidden="true" class="svg-icon iconStackExchange" width="18" height="18" viewBox="0 0 18 18"><path d="M1 13c0 1.1.9 2 2 2h8v3l3-3h1a2 2 0 0 0 2-2v-2H1v2zM15 1H3a2 2 0 0 0-2 2v2h16V3a2 2 0 0 0-2-2zM1 6h16v4H1V6z"/></svg>
        </a>
    </li>

            <li class="-ctas">
                        <a href="https://stackoverflow.com/users/login?ssrc=head&returnurl=https%3a%2f%2fstackoverflow.com%2fquestions%2f6998355%2fincluding-javascript-class-definition-from-another-file-in-node-js" class="login-link s-btn btn-topbar-clear py8" rel="nofollow">Log In</a>
                        <a href="https://stackoverflow.com/users/signup?ssrc=head&returnurl=%2fusers%2fstory%2fcurrent" class="login-link s-btn s-btn__primary py8 btn-topbar-primary" rel="nofollow" data-ga="[&quot;sign up&quot;,&quot;Sign Up Navigation&quot;,&quot;Header&quot;,null,null]">Sign Up</a>

            </li>

    <li class="-dialog-container js-topbar-dialog-corral">


    <div class="topbar-dialog siteSwitcher-dialog dno">
        <div class="header">
            <h3><a href="https://stackoverflow.com">current community</a>
            </h3>
        </div>
        <div class="modal-content current-site-container">
            <ul class="current-site">
                    <li class="grid">
                            <div class="fl1">
            <a href="https://stackoverflow.com"
       class="current-site-link site-link js-gps-track grid gs8 gsx"
       data-id="1"
       data-gps-track="site_switcher.click({ item_type:3 })">
        <div class="favicon favicon-stackoverflow site-icon grid--cell" title="Stack Overflow"></div>
        <span class="grid--cell fl1">
            Stack Overflow
        </span>
    </a>

    </div>
    <div class="related-links">
            <a href="https://stackoverflow.com/help" class="js-gps-track"     data-gps-track="site_switcher.click({ item_type:14 })"
>help</a>
                    <a href="https://chat.stackoverflow.com" class="js-gps-track"     data-gps-track="site_switcher.click({ item_type:6 })"
>chat</a>
            </div>

                    </li>
                    <li class="related-site grid">
                            <div class="L-shaped-icon-container">
        <span class="L-shaped-icon"></span>
    </div>

                            <a href="https://meta.stackoverflow.com"
       class="site-link js-gps-track grid gs8 gsx"
       data-id="552"
       data-gps-track="site.switch({ target_site:552, item_type:3 }),site_switcher.click({ item_type:4 })">
        <div class="favicon favicon-stackoverflowmeta site-icon grid--cell" title="Meta Stack Overflow"></div>
        <span class="grid--cell fl1">
            Meta Stack Overflow
        </span>
    </a>

                    </li>
            </ul>
        </div>

        <div class="header" id="your-communities-header">
            <h3>
your communities            </h3>

        </div>
        <div class="modal-content" id="your-communities-section">

                <div class="call-to-login">
<a href="https://stackoverflow.com/users/signup?ssrc=site_switcher&amp;returnurl=%2fusers%2fstory%2fcurrent" class="login-link js-gps-track"     data-gps-track="site_switcher.click({ item_type:10 })"
>Sign up</a> or <a href="https://stackoverflow.com/users/login?ssrc=site_switcher&amp;returnurl=https%3a%2f%2fstackoverflow.com%2fquestions%2f6998355%2fincluding-javascript-class-definition-from-another-file-in-node-js" class="login-link js-gps-track"     data-gps-track="site_switcher.click({ item_type:11 })"
>log in</a> to customize your list.
                </div>
        </div>

        <div class="header">
            <h3><a href="https://stackexchange.com/sites">more stack exchange communities</a>
            </h3>
            <a href="https://stackoverflow.blog" class="fr">company blog</a>
        </div>
        <div class="modal-content">
                <div class="child-content"></div>
        </div>        
    </div>
            <div class="topbar-dialog help-dialog js-help-dialog dno">
        <div class="modal-content">
            <ul>
                                    <li>
                        <a href="/tour" class="js-gps-track" data-gps-track="help_popup.click({ item_type:1 })">
                            Tour
                            <span class="item-summary">
                                Start here for a quick overview of the site
                            </span>
                        </a>
                    </li>
                <li>
                    <a href="/help" class="js-gps-track" data-gps-track="help_popup.click({ item_type:4 })">
                        Help Center
                        <span class="item-summary">
                            Detailed answers to any questions you might have
                        </span>
                    </a>
                </li>
                        <li>
                            <a href="https://meta.stackoverflow.com" class="js-gps-track" data-gps-track="help_popup.click({ item_type:2 })">
                                Meta
                                <span class="item-summary">
                                    Discuss the workings and policies of this site
                                </span>
                            </a>
                        </li>
                        <li>
                            <a href="https://stackoverflow.com/company/about" class="js-gps-track" data-gps-track="help_popup.click({ item_type:6 })">
                                About Us
                                <span class="item-summary">
                                    Learn more about Stack Overflow the company
                                </span>
                            </a>
                        </li>
                        <li>
                            <a href="https://www.stackoverflowbusiness.com/?ref=topbar_help" class="js-gps-track" data-gps-track="help_popup.click({ item_type:7 })">
                                Business
                                <span class="item-summary">
                                    Learn more about hiring developers or posting ads with us
                                </span>
                            </a>
                        </li>
            </ul>
        </div>
    </div>
                    <div class="topbar-dialog leftnav-dialog js-leftnav-dialog dno">
                <div class="left-sidebar js-unpinned-left-sidebar" data-can-be="left-sidebar" data-is-here-when="sm"></div>
            </div>
    </li>
</ol>

    </div>
</header>
    <div id="js-gdpr-consent-banner" class="p16 bg-black-700 ff-sans fc-white ps-fixed b0 l0 r0 z-banner" role="banner" aria-hidden="false">
        <div class="wmx8 mx-auto grid jc-center" role="alertdialog" aria-describedby="notice-message">
            <div class="grid--cell mr12" aria-label="notice-message">
                <p class="mb0 lh-lg">
                    By using our site, you acknowledge that you have read and understand our <a class="s-link s-link__inherit td-underline fc-white" target="_blank" href="https://stackoverflow.com/legal/cookie-policy">Cookie Policy</a>, <a class="s-link s-link__inherit td-underline fc-white" target="_blank" href="https://stackoverflow.com/legal/privacy-policy">Privacy Policy</a>, and our <a class="s-link s-link__inherit td-underline fc-white" target="_blank" href="https://stackoverflow.com/legal/terms-of-service/public">Terms of Service</a>.
                </p>
            </div>
            <a class="grid--cell fc-white js-notice-close" aria-label="notice-dismiss">
                <svg aria-hidden="true" class="svg-icon m0 iconClear" width="18" height="18" viewBox="0 0 18 18"><path d="M15 4.41L13.59 3 9 7.59 4.41 3 3 4.41 7.59 9 3 13.59 4.41 15 9 10.41 13.59 15 15 13.59 10.41 9z"/></svg>
            </a>
        </div>
    </div>

    <script>
        StackExchange.ready(function () { StackExchange.topbar.init({ observeSize: true }); });
        StackExchange.scrollPadding.setPaddingTop(50, 10);     </script>






    <div class="container">





<div id="left-sidebar" data-is-here-when="md lg" class="left-sidebar js-pinned-left-sidebar">
    <div class="left-sidebar--sticky-container js-sticky-leftnav">
            <nav role="navigation">
                <ol class="nav-links">
                    <li>    <li>
        <a
            href="/"
            class="pl8 js-gps-track nav-links--link"
            
            data-gps-track="top_nav.click({is_current:false, location:2, destination:8})">
Home        </a>
    </li>
</li>
                    <li>
                        <ol class="nav-links">
                                <li class="fs-fine tt-uppercase ml8 mt16 mb4 fc-light">Public</li>
                                <li class=" youarehere">
        <a id="nav-questions"
            href="/questions"
            class="pl8 js-gps-track nav-links--link -link__with-icon"
            
            data-gps-track="top_nav.click({is_current:true, location:2, destination:1})">
<svg aria-hidden="true" class="svg-icon iconGlobe" width="18" height="18" viewBox="0 0 18 18"><path d="M9 1a8 8 0 1 0 0 16A8 8 0 0 0 9 1zM8 15.32a6.4 6.4 0 0 1-5.23-7.75L7 11.68v.8c0 .88.12 1.32 1 1.32v1.52zm5.72-2c-.2-.66-1-1.32-1.72-1.32h-1v-2c0-.44-.56-1-1-1H6V7h1c.44 0 1-.56 1-1V5h2c.88 0 1.4-.72 1.4-1.6v-.33a6.4 6.4 0 0 1 2.32 10.24z"/></svg>                <span class="-link--channel-name">Stack Overflow</span>
        </a>
    </li>

    <li>
        <a id="nav-tags"
            href="/tags"
            class=" js-gps-track nav-links--link"
            
            data-gps-track="top_nav.click({is_current:false, location:2, destination:2})">
Tags        </a>
    </li>
    <li>
        <a id="nav-users"
            href="/users"
            class=" js-gps-track nav-links--link"
            
            data-gps-track="top_nav.click({is_current:false, location:2, destination:3})">
Users        </a>
    </li>
    <li>
        <a id="nav-jobs"
            href="/jobs?med=site-ui&amp;ref=jobs-tab"
            class=" js-gps-track nav-links--link"
            
            data-gps-track="top_nav.click({is_current:false, location:2, destination:6})">
Jobs        </a>
    </li>
                                                    </ol>
                    </li>
                        <li>
                            <ol class="nav-links">
                                        <li class="p6">
                                            <div class="ba bc-black-2 bar-sm p16 grid fd-column ps-relative overflow-hidden">
                                                <strong class="grid--cell">Teams</strong>
                                                <span class="grid--cell mt2 fs-caption fc-medium">Q&amp;A for work </span>
                                                <a href="https://stackoverflow.com/teams"
                                                   class="js-gps-track s-btn s-btn__outlined ta-center grid--cell mt12"
                                                   data-gps-track="teams.create.left-sidenav.click({ CampaignType: None})"
                                                   data-ga="[&quot;teams traffic&quot;,&quot;left nav cta&quot;,&quot;stackoverflow.com/teams&quot;,null,{&quot;dimension4&quot;:&quot;teams&quot;}]">
                                                    Learn More
                                                </a>

                                                <div class="ps-absolute t4 rn6">
                                                    <svg width="53" height="49" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M49 11l.2 31H18.9L9 49v-7H4V8h31" fill="#CCEAFF" /><path d="M44.5 19v-.3l-.2-.1-18-13-.1-.1H.5v33h4V46l.8-.6 9.9-6.9h29.3V19z" stroke="#1060E1" stroke-miterlimit="10" /><path d="M31 2l6-1.5 7 2V38H14.9L5 45v-7H1V6h25l5-4z" fill="#fff" /><path d="M7 16.5h13m-13 6h14m-14 6h18" stroke="#1060E1" stroke-miterlimit="10" /><path d="M39 30a14 14 0 1 0 0-28 14 14 0 0 0 0 28z" fill="#FFB935" /><path d="M50.5 14a13.5 13.5 0 1 1-27 0 13.5 13.5 0 0 1 27 0z" stroke="#F48024" stroke-miterlimit="10" /><path d="M32.5 21.5v-8h9v8h-9zm2-9.5V9.3A2.5 2.5 0 0 1 37 6.8a2.5 2.5 0 0 1 2.5 2.5V12h-5zm2 3v2m1-2v2" stroke="#fff" stroke-miterlimit="10" /></svg>
                                                </div>
                                            </div>
                                        </li>
                            </ol>
                        </li>
                </ol>
            </nav>
    </div>
</div>
   

        <div id="content" class="snippet-hidden">


            


<div itemprop="mainEntity" itemscope itemtype="http://schema.org/Question">
        <span class="js-cursor-container"></span>
        <div class="js-toggle-popover s-popover ff-sans d-none" style="position: absolute; top: 47px; width: 300px; left: -130px;">
            <button class="js-toggle-popover-close s-popover--close s-btn s-btn__muted" aria-label="Close">
                <svg aria-hidden="true" class="svg-icon iconClearSm" width="14" height="14" viewBox="0 0 14 14"><path d="M12 3.41L10.59 2 7 5.59 3.41 2 2 3.41 5.59 7 2 10.59 3.41 12 7 8.41 10.59 12 12 10.59 8.41 7z"/></svg>
            </button>
            <div class="s-popover--arrow__tc"></div>
            <span class="fw-bold mb8 d-block">Back to the future!</span>
            <span>Just like the &#39;90s, good things have to come to an end. If you want to switch to the current site, you&#39;ll find the option here.</span>
        </div>
    <link itemprop="image" href="https://cdn.sstatic.net/Sites/stackoverflow/img/apple-touch-icon.png?v=c78bd457575a">

    <div class="inner-content clearfix">
    
    

<style>.everyoneloves__top-leaderboard:empty,.everyoneloves__mid-leaderboard:empty,.everyoneloves__bot-mid-leaderboard:empty{                height:90px;width:728px;box-sizing:border-box;
}</style>
        <div id="dfp-tlb" class="everyonelovesstackoverflow everyoneloves__top-leaderboard"></div>            <div id="question-header" class="grid">
                    <h1 itemprop="name" class="grid--cell fs-headline1 fl1 ow-break-word"><a href="/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js" class="question-hyperlink">Including JavaScript class definition from another file in Node.js</a></h1>

            
<div class="pl8 aside-cta grid--cell" role="navigation" aria-label="ask new question">
        <a href="/questions/ask" class="d-inline-flex ai-center ws-nowrap s-btn s-btn__primary" >
            Ask Question
        </a>
</div>

        </div>
            <div id="mainbar" role="main" aria-label="question and answers">

            

<div class="question" data-questionid="6998355"  id="question">

    
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="6998355">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This question shows research effort; it is useful and clear" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="81">81</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This question does not show any research effort; it is unclear or not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>

        <button class="js-favorite-btn s-btn s-btn__unset c-pointer py8" aria-pressed="false" aria-label="favorite (14)" data-selected-classes="fc-yellow-600">
            <svg aria-hidden="true" class="svg-icon iconStar" width="18" height="18" viewBox="0 0 18 18"><path d="M9 12.65l-5.29 3.63 1.82-6.15L.44 6.22l6.42-.17L9 0l2.14 6.05 6.42.17-5.1 3.9 1.83 6.16z"/></svg>
            <div class="js-favorite-count mt8" data-value="14">14</div>
        </button>


</div>

            </div>

            
<div class="postcell post-layout--right">
    
    <div class="post-text" itemprop="text">

<p>I'm writing a simple server for Node.js and I'm using my own class called <code>User</code> which looks like:</p>

<pre><code>function User(socket) {
    this.socket = socket;
    this.nickname = null;

    /* ... just the typical source code like functions, variables and bugs ... */

    this.write = function(object) {
        this.socket.write(JSON.stringify(object));
    }
};
</code></pre>

<p>and then later in the process I'm instantiating it a lot:</p>

<pre><code>var server = net.createServer(function (socket) {
    /* other bugs */
    var user = new User(socket);
    /* more bugs and bad practise */
});
</code></pre>

<p>Can I move my <code>User</code> class definition to another javascript file and "include" it somehow?</p>
    </div>

        <div class="post-taglist grid gs4 gsy fd-column">
            <div class="grid ps-relative d-block">
                <a href="/questions/tagged/javascript" class="post-tag" title="show questions tagged &#39;javascript&#39;" rel="tag">javascript</a> <a href="/questions/tagged/node.js" class="post-tag" title="show questions tagged &#39;node.js&#39;" rel="tag">node.js</a> 
            </div>
        </div>

    <div class="mb0 ">
        <div class="mt16 pt4 grid gs8 gsy fw-wrap jc-end ai-start">
            <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/q/6998355" title="short permalink to this question" class="short-link" itemprop="url" id="link-post-6998355">share</a><span class="lsep">|</span><a href="/posts/6998355/edit" class="suggest-edit-post" title="">improve this question</a></div>
            </div>

                <div class="post-signature grid--cell">
<div class="user-info ">
    <div class="user-action-time">
        <a href="/posts/6998355/revisions" title="show all edits to this post">edited <span title="2019-03-15 04:58:03Z" class="relativetime">Mar 15 at 4:58</span></a>
    </div>
    <div class="user-gravatar32">
        <a href="/users/884491/paul-rumkin"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/132f685f8b44731e5d0a4eee599bec67?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details">
        <a href="/users/884491/paul-rumkin">Paul Rumkin</a>
        <div class="-flair">
            <span class="reputation-score" title="reputation score " dir="ltr">3,190</span><span title="2 gold badges"><span class="badge1"></span><span class="badgecount">2</span></span><span title="16 silver badges"><span class="badge2"></span><span class="badgecount">16</span></span><span title="27 bronze badges"><span class="badge3"></span><span class="badgecount">27</span></span>
        </div>
    </div>
</div>                </div>
            <div class="post-signature owner grid--cell">
<div class="user-info user-hover">
    <div class="user-action-time">
        asked <span title="2011-08-09 15:04:13Z" class="relativetime">Aug 9 '11 at 15:04</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/310726/martin"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/cc38ee5e151f1efb6470740c66262058?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/310726/martin">martin</a><span class="d-none" itemprop="name">martin</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score 46,497" dir="ltr">46.5k</span><span title="11 gold badges"><span class="badge1"></span><span class="badgecount">11</span></span><span title="93 silver badges"><span class="badge2"></span><span class="badgecount">93</span></span><span title="137 bronze badges"><span class="badge3"></span><span class="badgecount">137</span></span>
        </div>
    </div>
</div>

            </div>
        </div>
    </div>
    
</div>
                
    <div class="post-layout--right">
	    <div id="comments-6998355" class="comments js-comments-container  dno" data-post-id="6998355">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="0"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">

            </ul>
	    </div>

        <div id="comments-link-6998355" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link disabled-link "
                   title="Use comments to ask for more information or suggest improvements. Avoid answering questions in comments."
                   >add a comment</a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link dno" title="expand to show all comments on this post" href=# onclick=""></a>
        </div>         
    </div>        </div>
</div>


<div id="dfp-isb" class="everyonelovesstackoverflow everyoneloves__inline-sidebar"></div>
            <div id="answers">

                <a name="tab-top"></a>
                <div id="answers-header">
                    <div class="subheader answers-subheader">
                        <h2 data-answercount="5">
                                5 Answers
                            <span style="display:none;" itemprop="answerCount">5</span>
                        </h2>
                        <div>
                            
<div id="tabs">
        <a href="/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js?answertab=active#tab-top" data-nav-xhref="" title="Answers with the latest activity first" data-value="active" data-shortcut="A">
            active</a>
        <a href="/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js?answertab=oldest#tab-top" data-nav-xhref="" title="Answers in the order they were provided" data-value="oldest" data-shortcut="O">
            oldest</a>
        <a class="youarehere is-selected " href="/questions/6998355/including-javascript-class-definition-from-another-file-in-node-js?answertab=votes#tab-top" data-nav-xhref="" title="Answers with the highest score first" data-value="votes" data-shortcut="V">
            votes</a>
    </div>

                        </div>
                    </div>
                </div>




  
<a name="6998650"></a>
<div id="answer-6998650" class="answer accepted-answer" data-answerid="6998650"  itemprop="acceptedAnswer" itemscope itemtype="http://schema.org/Answer">
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="6998650">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is useful" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="137">137</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>


                <div class="js-accepted-answer-indicator grid--item fc-green-500 ta-center p4" title="loading when this answer was accepted..." tabindex="0" role="note" aria-label="accepted"><svg aria-hidden="true" class="svg-icon iconCheckmarkLg" width="36" height="36" viewBox="0 0 36 36"><path d="M6 14l8 8L30 6v8L14 30l-8-8z"/></svg></div>

</div>

            </div>
            

<div class="answercell post-layout--right">
    
    <div class="post-text" itemprop="text">
<p>And even you can simply do this</p>

<p><strong>user.js</strong>
</p>

<pre><code>class User {
    //...
};

module.exports = User;
</code></pre>

<p><strong>server.js</strong>
</p>

<pre><code>const User = require('./user.js');

// Instantiate User:
let user = new User();
</code></pre>

<p>P.S. And don't use globals. It creates potential conflicts in the future.</p>
    </div>
    <div class="grid mb0 fw-wrap ai-start jc-end gs8 gsy">
        <time itemprop="dateCreated" datetime="2011-08-09T15:24:00"></time>
    <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/a/6998650" title="short permalink to this answer" class="short-link" itemprop="url" id="link-post-6998650">share</a><span class="lsep">|</span><a href="/posts/6998650/edit" class="suggest-edit-post" title="">improve this answer</a></div>                    </div>
    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        <a href="/posts/6998650/revisions" title="show all edits to this post">edited <span title="2017-12-25 19:04:41Z" class="relativetime">Dec 25 '17 at 19:04</span></a>
    </div>
    <div class="user-gravatar32">
        
    </div>
    <div class="user-details">
        
        <div class="-flair">
            
        </div>
    </div>
</div>    </div>
            


    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        answered <span title="2011-08-09 15:24:00Z" class="relativetime">Aug 9 '11 at 15:24</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/884491/paul-rumkin"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/132f685f8b44731e5d0a4eee599bec67?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/884491/paul-rumkin">Paul Rumkin</a><span class="d-none" itemprop="name">Paul Rumkin</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score " dir="ltr">3,190</span><span title="2 gold badges"><span class="badge1"></span><span class="badgecount">2</span></span><span title="16 silver badges"><span class="badge2"></span><span class="badgecount">16</span></span><span title="27 bronze badges"><span class="badge3"></span><span class="badgecount">27</span></span>
        </div>
    </div>
</div>

    </div>
    </div>
    
</div>

    
    <div class="post-layout--right">
	    <div id="comments-6998650" class="comments js-comments-container " data-post-id="6998650">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="4"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">


    <li id="comment-31572093" class="comment js-comment " data-comment-id="31572093">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">what if, User had some input parameters, like module.exports = function User(data). Then the var user = new User(); whould have been changed to var user = new User(data);?</span>
                
                    &ndash;&nbsp;<a href="/users/699559/c-graphics"
                       title="2,660 reputation"
                       class="comment-user">C graphics</a>
                <span class="comment-date" dir="ltr"><span title="2014-01-08 21:40:54Z" class="relativetime-clean">Jan 8 '14 at 21:40</span></span>
                                                            </div>
        </div>
    </li>
    <li id="comment-31635113" class="comment js-comment " data-comment-id="31635113">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">Yes. <code>User</code> is usual js function.</span>
                
                    &ndash;&nbsp;<a href="/users/884491/paul-rumkin"
                       title="3,190 reputation"
                       class="comment-user">Paul Rumkin</a>
                <span class="comment-date" dir="ltr"><span title="2014-01-10 10:56:27Z" class="relativetime-clean">Jan 10 '14 at 10:56</span></span>
                        <span title="this comment was edited 1 time">
                            <svg aria-hidden="true" class="svg-icon va-text-bottom o50 iconPencilSm" width="14" height="14" viewBox="0 0 14 14"><path d="M8.37 3.7L2 10.11V12h1.88l6.37-6.43zM12.23 2.83L11.1 1.71a.5.5 0 0 0-.7 0L9.2 2.86l1.88 1.84 1.14-1.16a.5.5 0 0 0 0-.71z"/></svg>
                        </span>
                                                            </div>
        </div>
    </li>
    <li id="comment-35126531" class="comment js-comment " data-comment-id="35126531">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
                    <span title="number of &#39;useful comment&#39; votes received"
                            class="warm">6</span>
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">finally, secret of modules revealed in few lines!!!!!</span>
                
                    &ndash;&nbsp;<a href="/users/310662/holms"
                       title="4,174 reputation"
                       class="comment-user">holms</a>
                <span class="comment-date" dir="ltr"><span title="2014-04-10 21:02:26Z" class="relativetime-clean">Apr 10 '14 at 21:02</span></span>
                        <span title="this comment was edited 1 time">
                            <svg aria-hidden="true" class="svg-icon va-text-bottom o50 iconPencilSm" width="14" height="14" viewBox="0 0 14 14"><path d="M8.37 3.7L2 10.11V12h1.88l6.37-6.43zM12.23 2.83L11.1 1.71a.5.5 0 0 0-.7 0L9.2 2.86l1.88 1.84 1.14-1.16a.5.5 0 0 0 0-.71z"/></svg>
                        </span>
                                                            </div>
        </div>
    </li>
    <li id="comment-82904131" class="comment js-comment " data-comment-id="82904131">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
                    <span title="number of &#39;useful comment&#39; votes received"
                            class="cool">2</span>
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">You don&#39;t need to create the constant User in server.js. Change the last line of users.js into <code>module.exports = new User();</code> This will create a new instance of User each time the module is required. Then you can simply require the module for each variable like this: <code>let user = require(&#39;.&#47;user.js&#39;);</code>.</span>
                
                    &ndash;&nbsp;<a href="/users/4528199/nadav"
                       title="473 reputation"
                       class="comment-user">Nadav</a>
                <span class="comment-date" dir="ltr"><span title="2017-12-25 09:26:51Z" class="relativetime-clean">Dec 25 '17 at 9:26</span></span>
                                                            </div>
        </div>
    </li>
    <li id="comment-88428170" class="comment js-comment " data-comment-id="88428170">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
                    <span title="number of &#39;useful comment&#39; votes received"
                            class="cool">1</span>
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">@Barnack There are several my answers. Which is wrong and which is correct?</span>
                
                    &ndash;&nbsp;<a href="/users/884491/paul-rumkin"
                       title="3,190 reputation"
                       class="comment-user">Paul Rumkin</a>
                <span class="comment-date" dir="ltr"><span title="2018-06-05 22:00:55Z" class="relativetime-clean">Jun 5 '18 at 22:00</span></span>
                                                            </div>
        </div>
    </li>
            </ul>
	    </div>

        <div id="comments-link-6998650" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link  dno"
                   title="Use comments to ask for more information or suggest improvements. Avoid comments like “+1” or “thanks”."
                   ></a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link " title="expand to show all comments on this post" href=# onclick="">show <b>4</b> more comments</a>
        </div>         
    </div>    </div>
</div>
<div id="dfp-mlb" class="everyonelovesstackoverflow everyoneloves__mid-leaderboard"></div>
  
<a name="41416461"></a>
<div id="answer-41416461" class="answer" data-answerid="41416461"  itemprop="suggestedAnswer" itemscope itemtype="http://schema.org/Answer">
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="41416461">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is useful" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="11">11</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>


                <div class="js-accepted-answer-indicator grid--item fc-green-500 ta-center p4 d-none" title="loading when this answer was accepted..." tabindex="0" role="note" aria-label="accepted"><svg aria-hidden="true" class="svg-icon iconCheckmarkLg" width="36" height="36" viewBox="0 0 36 36"><path d="M6 14l8 8L30 6v8L14 30l-8-8z"/></svg></div>

</div>

            </div>
            

<div class="answercell post-layout--right">
    
    <div class="post-text" itemprop="text">
<p>Using ES6, you can have <code>user.js</code>:</p>

<pre><code>export default class User {
  constructor() {
    ...
  }
}
</code></pre>

<p>And then use it in <code>server.js</code></p>

<pre><code>const User = require('./user.js').default;
const user = new User();
</code></pre>
    </div>
    <div class="grid mb0 fw-wrap ai-start jc-end gs8 gsy">
        <time itemprop="dateCreated" datetime="2017-01-01T15:13:21"></time>
    <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/a/41416461" title="short permalink to this answer" class="short-link" itemprop="url" id="link-post-41416461">share</a><span class="lsep">|</span><a href="/posts/41416461/edit" class="suggest-edit-post" title="">improve this answer</a></div>                    </div>
            


    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        answered <span title="2017-01-01 15:13:21Z" class="relativetime">Jan 1 '17 at 15:13</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/1657896/yedidyak"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/759dc5594467a79884a016e5d29c7976?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/1657896/yedidyak">yedidyak</a><span class="d-none" itemprop="name">yedidyak</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score " dir="ltr">1,679</span><span title="10 silver badges"><span class="badge2"></span><span class="badgecount">10</span></span><span title="25 bronze badges"><span class="badge3"></span><span class="badgecount">25</span></span>
        </div>
    </div>
</div>

    </div>
    </div>
    
</div>

    
    <div class="post-layout--right">
	    <div id="comments-41416461" class="comments js-comments-container  dno" data-post-id="41416461">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="0"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">

            </ul>
	    </div>

        <div id="comments-link-41416461" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link disabled-link "
                   title="Use comments to ask for more information or suggest improvements. Avoid comments like “+1” or “thanks”."
                   >add a comment</a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link dno" title="expand to show all comments on this post" href=# onclick=""></a>
        </div>         
    </div>    </div>
</div>

  
<a name="6998462"></a>
<div id="answer-6998462" class="answer" data-answerid="6998462"  itemprop="suggestedAnswer" itemscope itemtype="http://schema.org/Answer">
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="6998462">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is useful" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="6">6</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>


                <div class="js-accepted-answer-indicator grid--item fc-green-500 ta-center p4 d-none" title="loading when this answer was accepted..." tabindex="0" role="note" aria-label="accepted"><svg aria-hidden="true" class="svg-icon iconCheckmarkLg" width="36" height="36" viewBox="0 0 36 36"><path d="M6 14l8 8L30 6v8L14 30l-8-8z"/></svg></div>

</div>

            </div>
            

<div class="answercell post-layout--right">
    
    <div class="post-text" itemprop="text">
<p>Modify your class definition to read like this:</p>

<pre><code>exports.User = function (socket) {
  ...
};
</code></pre>

<p>Then rename the file to <code>user.js</code>. Assuming it's in the root directory of your main script, you can include it like this:</p>

<pre><code>var user = require('./user');
var someUser = new user.User();
</code></pre>

<p>That's the quick and dirty version. Read about <a href="http://wiki.commonjs.org/wiki/Modules/1.1" rel="noreferrer">CommonJS Modules</a> if you'd like to learn more.</p>
    </div>
    <div class="grid mb0 fw-wrap ai-start jc-end gs8 gsy">
        <time itemprop="dateCreated" datetime="2011-08-09T15:11:23"></time>
    <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/a/6998462" title="short permalink to this answer" class="short-link" itemprop="url" id="link-post-6998462">share</a><span class="lsep">|</span><a href="/posts/6998462/edit" class="suggest-edit-post" title="">improve this answer</a></div>                    </div>
            


    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        answered <span title="2011-08-09 15:11:23Z" class="relativetime">Aug 9 '11 at 15:11</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/424107/sevenflow"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/b266ba1c5a3574c8a250da7681a4c253?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/424107/sevenflow">sevenflow</a><span class="d-none" itemprop="name">sevenflow</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score " dir="ltr">357</span><span title="1 gold badge"><span class="badge1"></span><span class="badgecount">1</span></span><span title="3 silver badges"><span class="badge2"></span><span class="badgecount">3</span></span><span title="19 bronze badges"><span class="badge3"></span><span class="badgecount">19</span></span>
        </div>
    </div>
</div>

    </div>
    </div>
    
</div>

    
    <div class="post-layout--right">
	    <div id="comments-6998462" class="comments js-comments-container " data-post-id="6998462">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="0"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">


    <li id="comment-31572039" class="comment js-comment " data-comment-id="31572039">
        <div class="js-comment-actions comment-actions">
            <div class="comment-score js-comment-edit-hide">
                    <span title="number of &#39;useful comment&#39; votes received"
                            class="cool">2</span>
            </div>
                    </div>
        <div class="comment-text js-comment-text-and-form">
            <div class="comment-body js-comment-edit-hide">
                
                <span class="comment-copy">What happened to socket? should it be var someUser = new user.User(socket);</span>
                
                    &ndash;&nbsp;<a href="/users/699559/c-graphics"
                       title="2,660 reputation"
                       class="comment-user">C graphics</a>
                <span class="comment-date" dir="ltr"><span title="2014-01-08 21:39:09Z" class="relativetime-clean">Jan 8 '14 at 21:39</span></span>
                                                            </div>
        </div>
    </li>
            </ul>
	    </div>

        <div id="comments-link-6998462" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link disabled-link "
                   title="Use comments to ask for more information or suggest improvements. Avoid comments like “+1” or “thanks”."
                   >add a comment</a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link dno" title="expand to show all comments on this post" href=# onclick=""></a>
        </div>         
    </div>    </div>
</div>

  
<a name="41579208"></a>
<div id="answer-41579208" class="answer" data-answerid="41579208"  itemprop="suggestedAnswer" itemscope itemtype="http://schema.org/Answer">
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="41579208">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is useful" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="5">5</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>


                <div class="js-accepted-answer-indicator grid--item fc-green-500 ta-center p4 d-none" title="loading when this answer was accepted..." tabindex="0" role="note" aria-label="accepted"><svg aria-hidden="true" class="svg-icon iconCheckmarkLg" width="36" height="36" viewBox="0 0 36 36"><path d="M6 14l8 8L30 6v8L14 30l-8-8z"/></svg></div>

</div>

            </div>
            

<div class="answercell post-layout--right">
    
    <div class="post-text" itemprop="text">
<p>Another way in addition to the ones provided here for ES6</p>

<pre><code>module.exports = class TEST{
    constructor(size) {
        this.map = new MAp();
        this.size = size;

    }

    get(key) {
        return this.map.get(key);
    }

    length() {
        return this.map.size;
    }    

}
</code></pre>

<p>and include the same as </p>

<pre><code>var TEST= require('./TEST');
var test = new TEST(1);
</code></pre>
    </div>
    <div class="grid mb0 fw-wrap ai-start jc-end gs8 gsy">
        <time itemprop="dateCreated" datetime="2017-01-10T22:00:54"></time>
    <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/a/41579208" title="short permalink to this answer" class="short-link" itemprop="url" id="link-post-41579208">share</a><span class="lsep">|</span><a href="/posts/41579208/edit" class="suggest-edit-post" title="">improve this answer</a></div>                    </div>
            


    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        answered <span title="2017-01-10 22:00:54Z" class="relativetime">Jan 10 '17 at 22:00</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/896315/gaurav-rawat"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/a519e9a99bd5110098fbc798216daf02?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/896315/gaurav-rawat">Gaurav Rawat</a><span class="d-none" itemprop="name">Gaurav Rawat</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score " dir="ltr">653</span><span title="17 silver badges"><span class="badge2"></span><span class="badgecount">17</span></span><span title="30 bronze badges"><span class="badge3"></span><span class="badgecount">30</span></span>
        </div>
    </div>
</div>

    </div>
    </div>
    
</div>

    
    <div class="post-layout--right">
	    <div id="comments-41579208" class="comments js-comments-container  dno" data-post-id="41579208">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="0"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">

            </ul>
	    </div>

        <div id="comments-link-41579208" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link disabled-link "
                   title="Use comments to ask for more information or suggest improvements. Avoid comments like “+1” or “thanks”."
                   >add a comment</a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link dno" title="expand to show all comments on this post" href=# onclick=""></a>
        </div>         
    </div>    </div>
</div>

  
<a name="6998474"></a>
<div id="answer-6998474" class="answer" data-answerid="6998474"  itemprop="suggestedAnswer" itemscope itemtype="http://schema.org/Answer">
    <div class="post-layout">
            <div class="votecell post-layout--left">
                

<div class="js-voting-container grid fd-column ai-stretch gs4 fc-black-200" data-post-id="6998474">
        <button class="js-vote-up-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is useful" aria-pressed="false" aria-label="up vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowUpLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 26h32L18 10z"/></svg></button>
        <div class="js-vote-count grid--cell fc-black-500 fs-title grid fd-column ai-center" itemprop="upvoteCount" data-value="1">1</div>
        <button class="js-vote-down-btn grid--cell s-btn s-btn__unset c-pointer" title="This answer is not useful" aria-pressed="false" aria-label="down vote" data-selected-classes="fc-theme-primary"><svg aria-hidden="true" class="svg-icon m0 iconArrowDownLg" width="36" height="36" viewBox="0 0 36 36"><path d="M2 10h32L18 26z"/></svg></button>


                <div class="js-accepted-answer-indicator grid--item fc-green-500 ta-center p4 d-none" title="loading when this answer was accepted..." tabindex="0" role="note" aria-label="accepted"><svg aria-hidden="true" class="svg-icon iconCheckmarkLg" width="36" height="36" viewBox="0 0 36 36"><path d="M6 14l8 8L30 6v8L14 30l-8-8z"/></svg></div>

</div>

            </div>
            

<div class="answercell post-layout--right">
    
    <div class="post-text" itemprop="text">
<p>If you append this to <code>user.js</code>:</p>

<pre><code>exports.User = User;
</code></pre>

<p>then in <code>server.js</code> you can do:</p>

<pre><code>var userFile = require('./user.js');
var User = userFile.User;
</code></pre>

<p><a href="http://nodejs.org/docs/v0.4.10/api/globals.html#require" rel="nofollow">http://nodejs.org/docs/v0.4.10/api/globals.html#require</a></p>

<p>Another way is:</p>

<pre><code>global.User = User;
</code></pre>

<p>then this would be enough in <code>server.js</code>:</p>

<pre><code>require('./user.js');
</code></pre>
    </div>
    <div class="grid mb0 fw-wrap ai-start jc-end gs8 gsy">
        <time itemprop="dateCreated" datetime="2011-08-09T15:12:03"></time>
    <div class="grid--cell mr16" style="flex: 1 1 100px;">
<div class="post-menu"><a href="/a/6998474" title="short permalink to this answer" class="short-link" itemprop="url" id="link-post-6998474">share</a><span class="lsep">|</span><a href="/posts/6998474/edit" class="suggest-edit-post" title="">improve this answer</a></div>                    </div>
            


    <div class="post-signature grid--cell fl0">
<div class="user-info ">
    <div class="user-action-time">
        answered <span title="2011-08-09 15:12:03Z" class="relativetime">Aug 9 '11 at 15:12</span>
    </div>
    <div class="user-gravatar32">
        <a href="/users/514749/pimvdb"><div class="gravatar-wrapper-32"><img src="https://www.gravatar.com/avatar/4ce057b4df8da1d888a8034ec785ae76?s=32&amp;d=identicon&amp;r=PG" alt="" width="32" height="32"></div></a>
    </div>
    <div class="user-details" itemprop="author" itemscope itemtype="http://schema.org/Person">
        <a href="/users/514749/pimvdb">pimvdb</a><span class="d-none" itemprop="name">pimvdb</span>
        <div class="-flair">
            <span class="reputation-score" title="reputation score 113,573" dir="ltr">114k</span><span title="58 gold badges"><span class="badge1"></span><span class="badgecount">58</span></span><span title="274 silver badges"><span class="badge2"></span><span class="badgecount">274</span></span><span title="337 bronze badges"><span class="badge3"></span><span class="badgecount">337</span></span>
        </div>
    </div>
</div>

    </div>
    </div>
    
</div>

    
    <div class="post-layout--right">
	    <div id="comments-6998474" class="comments js-comments-container  dno" data-post-id="6998474">
            <ul class="comments-list js-comments-list"
                    data-remaining-comments-count="0"
                    data-canpost="false"
                    data-cansee="true"
                    data-comments-unavailable="false"
                    data-addlink-disabled="true">

            </ul>
	    </div>

        <div id="comments-link-6998474" data-rep=50 data-anon=true>

                <a class="js-add-link comments-link disabled-link "
                   title="Use comments to ask for more information or suggest improvements. Avoid comments like “+1” or “thanks”."
                   >add a comment</a><span class="js-link-separator dno">&nbsp;|&nbsp;</span>
            <a class="js-show-link comments-link dno" title="expand to show all comments on this post" href=# onclick=""></a>
        </div>         
    </div>    </div>
</div>
                                    <a name='new-answer'></a>
                        <form id="post-form" action="/questions/6998355/answer/submit" method="post"  class="post-form">
                            <input type="hidden" id="post-id" value="6998355" />
                            <input type="hidden" id="qualityBanWarningShown" name="qualityBanWarningShown" value="false" />
                            <input type="hidden" name="referrer" value="https://www.google.com/" />
                            <h2 class="space">
                                    <img src="https://cdn.sstatic.net/Img/april-fools-2019/your-answer.png?v=05356d22c757" alt="Your Answer" />
                            </h2>



            <script>
            StackExchange.ifUsing("editor", function () {
                StackExchange.using("externalEditor", function () {
                    StackExchange.using("snippets", function () {
                        StackExchange.snippets.init();
                    });
                });
            }, "code-snippets");
        </script>
    

<script>
    StackExchange.ready(function() {
        var channelOptions = {
            tags: "".split(" "),
            id: "1"
        };
        initTagRenderer("".split(" "), "".split(" "), channelOptions);
       
        StackExchange.using("externalEditor", function() {
                // Have to fire editor after snippets, if snippets enabled
                if (StackExchange.settings.snippets.snippetsEnabled) {
                    StackExchange.using("snippets", function() {
                        createEditor();
                    });
                }
                else {
                    createEditor();
                }
            });

            function createEditor() {
                StackExchange.prepareEditor({
                    heartbeatType: 'answer',
                    autoActivateHeartbeat: false,
                    convertImagesToLinks: true,
                noModals: true,
                showLowRepImageUploadWarning: true,
                reputationToPostImages: 10,
                bindNavPrevention: true,
                postfix: "",
                imageUploader: {
                    brandingHtml: "Powered by \u003ca class=\"icon-imgur-white\" href=\"https://imgur.com/\"\u003e\u003c/a\u003e",
                    contentPolicyHtml: "User contributions licensed under \u003ca href=\"https://creativecommons.org/licenses/by-sa/3.0/\"\u003ecc by-sa 3.0 with attribution required\u003c/a\u003e \u003ca href=\"https://stackoverflow.com/legal/content-policy\"\u003e(content policy)\u003c/a\u003e",
                    allowUrls: true
                },
                    onDemand: true,
                    discardSelector: ".discard-answer"
                    ,immediatelyShowMarkdownHelp:true
                    });
                

        }
    });
</script>


<div id="post-editor" class="post-editor js-post-editor js-wz-element" data-wz-state = "8,16,32,64,128,256">

    <div class="ps-relative"> 
        <div class="wmd-container mb8">
            <div id="wmd-button-bar" class="wmd-button-bar btr-sm"></div>
                        <div class="js-stacks-validation">
                <div class="ps-relative">
                    <textarea id="wmd-input" class="wmd-input js-wz-element s-input bar0" name="post-text" cols="92" rows="15" tabindex="101" data-wz-state = "256" data-min-length=""></textarea>
                </div>
                <div class="s-input-message mt4 d-none js-stacks-validation-message"></div>
            </div>
        </div>
    </div>

    <aside class="grid ai-start jc-space-between js-answer-help s-notice s-notice__warning pb0 pr4 pt4 mb8 d-none" role="status" aria-hidden="true">
    <div class="grid--cell pt8">
        <p>Thanks for contributing an answer to Stack Overflow!</p><ul><li>Please be sure to <em>answer the question</em>. Provide details and share your research!</li></ul><p>But <em>avoid</em> …</p><ul><li>Asking for help, clarification, or responding to other answers.</li><li>Making statements based on opinion; back them up with references or personal experience.</li></ul><p>To learn more, see our <a href="/help/how-to-answer">tips on writing great answers</a>.</p>
    </div>
    <button class="grid--cell js-answer-help-close-btn s-btn s-btn__muted fc-dark">
        <svg aria-hidden="true" class="svg-icon iconClear" width="18" height="18" viewBox="0 0 18 18"><path d="M15 4.41L13.59 3 9 7.59 4.41 3 3 4.41 7.59 9 3 13.59 4.41 15 9 10.41 13.59 15 15 13.59 10.41 9z"/></svg>
    </button>
</aside>


    <div id="draft-saved" class="draft-saved community-option fl" style="height:24px; display:none;">draft saved</div>
    <div id="draft-discarded" class="draft-discarded community-option fl" style="height:24px; display:none;">draft discarded</div>



    <div id="wmd-preview" class="wmd-preview"></div>
    <div></div>
    <div class="edit-block">
        <input id="fkey" name="fkey" type="hidden" value="cc776723d6fbd4b216f0f3b71598dcbe5e4f247dee506bb825bc1c894126e9e2">
        <input id="author" name="author" type="text">
    </div>



</div>

                            <div class="ps-relative">
                                
                                            <div class="form-item dno new-post-login p0 my16">
                <div class="grid gs16 md:fd-column new-login-form">
                    <div class="grid fd-column w50 md:w-auto gsy gs8 jc-space-between new-login-left">
                        <h3 class="grid--cell fs-title">Sign up or <a id="login-link" href="/users/login?ssrc=question_page&returnurl=https%3a%2f%2fstackoverflow.com%2fquestions%2f6998355%2fincluding-javascript-class-definition-from-another-file-in-node-js%23new-answer">log in</a></h3>
                        <script>
                            StackExchange.ready(function () {
                                StackExchange.helpers.onClickDraftSave('#login-link');
                            });
                        </script>
                        <div class="grid--cell ta-center s-btn s-btn__muted s-btn__outlined s-btn__icon google-login" data-ga="[&quot;sign up&quot;,&quot;Sign Up Started - Google&quot;,&quot;New Post&quot;,null,null]">
                            <svg aria-hidden="true" class="svg-icon native iconGoogle" width="18" height="18" viewBox="0 0 18 18"><g><path d="M16.51 8H8.98v3h4.3c-.18 1-.74 1.48-1.6 2.04v2.01h2.6a7.8 7.8 0 0 0 2.38-5.88c0-.57-.05-.66-.15-1.18z" fill="#4285F4"/><path d="M8.98 17c2.16 0 3.97-.72 5.3-1.94l-2.6-2a4.8 4.8 0 0 1-7.18-2.54H1.83v2.07A8 8 0 0 0 8.98 17z" fill="#34A853"/><path d="M4.5 10.52a4.8 4.8 0 0 1 0-3.04V5.41H1.83a8 8 0 0 0 0 7.18l2.67-2.07z" fill="#FBBC05"/><path d="M8.98 4.18c1.17 0 2.23.4 3.06 1.2l2.3-2.3A8 8 0 0 0 1.83 5.4L4.5 7.49a4.77 4.77 0 0 1 4.48-3.3z" fill="#EA4335"/></g></svg> Sign up using Google
                        </div>
                        <div class="grid--cell ta-center s-btn s-btn__muted s-btn__icon facebook-login" data-ga="[&quot;sign up&quot;,&quot;Sign Up Started - Facebook&quot;,&quot;New Post&quot;,null,null]">
                            <svg aria-hidden="true" class="svg-icon iconFacebook" width="18" height="18" viewBox="0 0 18 18"><path d="M1.88 1C1.4 1 1 1.4 1 1.88v14.24c0 .48.4.88.88.88h7.67v-6.2H7.46V8.4h2.09V6.61c0-2.07 1.26-3.2 3.1-3.2.88 0 1.64.07 1.87.1v2.16h-1.29c-1 0-1.19.48-1.19 1.18V8.4h2.39l-.31 2.42h-2.08V17h4.08c.48 0 .88-.4.88-.88V1.88c0-.48-.4-.88-.88-.88H1.88z" fill="#3C5A96"/></svg> Sign up using Facebook
                        </div>
                        <div class="grid--cell ta-center s-btn s-btn__muted s-btn__outlined s-btn__icon stackexchange-login" data-ga="[&quot;sign up&quot;,&quot;Sign Up Navigation&quot;,&quot;New Post&quot;,null,null]">
                            <svg aria-hidden="true" class="svg-icon native iconLogoGlyphXSm" width="18" height="18" viewBox="0 0 18 18"><g><path fill="#BCBBBB" d="M14 16v-5h2v7H2v-7h2v5z"/><path d="M5 15v-2h8v2H5zM12.09.72l4.5 6.06-1.2.9-4.51-6.06 1.21-.9zM8.34 4.3l.97-1.16 5.8 4.83-.96 1.16-5.8-4.83zm-1.9 3.36l.64-1.37 6.85 3.19-.63 1.37-6.85-3.2zM5.4 11.39l.38-1.67 7.42 1.48-.22 1.46-7.58-1.27z" fill="#F48024"/></g></svg> Sign up using Email and Password
                        </div>
                    </div>
                    <input type="hidden" name="use-facebook" class="use-facebook" value="false" />
                    <input type="hidden" name="use-google" class="use-google" value="false" />
                    <input type="button" class="submit-openid" value="Submit" style="display:none" />
                    <div class="grid gsy gs8 fd-column w50 md:w-auto new-login-right form-item p0">
                                <h3 class="grid--cell fs-title">Post as a guest</h3>
            <div class="grid--cell">
                <div class="grid gs4 gsy fd-column">
                    <label class="s-label" for="display-name">Name</label>
                    <div class="grid ps-relative">
                        <input class="s-input" id="display-name" name="display-name" maxlength="30" type="text" value="" tabindex="105" placeholder="" />
                    </div>
                </div>
            </div>
            <div class="grid--cell">
                <div class="grid gs4 gsy fd-column">
                    <div class="grid--cell">
                        <div class="grid gs2 gsy fd-column">
                            <label class="grid--cell s-label" for="m-address">Email</label>
                            <p class="grid--cell s-description">Required, but never shown</p>
                        </div>
                    </div>
                    <div class="grid ps-relative">
                        <input class="s-input" id="m-address" name="m-address" type="text" value="" size="40" tabindex="106" placeholder="" />
                    </div>
                </div>
            </div>

                    </div>
                </div>
            </div>
            <script>
                StackExchange.ready(
                    function () {
                        StackExchange.openid.initPostLogin('.new-post-login', 'https%3a%2f%2fstackoverflow.com%2fquestions%2f6998355%2fincluding-javascript-class-definition-from-another-file-in-node-js%23new-answer', 'question_page');
                    }
                );
            </script>
            <noscript>
                        <h3 class="grid--cell fs-title">Post as a guest</h3>
            <div class="grid--cell">
                <div class="grid gs4 gsy fd-column">
                    <label class="s-label" for="display-name">Name</label>
                    <div class="grid ps-relative">
                        <input class="s-input" id="display-name" name="display-name" maxlength="30" type="text" value="" tabindex="105" placeholder="" />
                    </div>
                </div>
            </div>
            <div class="grid--cell">
                <div class="grid gs4 gsy fd-column">
                    <div class="grid--cell">
                        <div class="grid gs2 gsy fd-column">
                            <label class="grid--cell s-label" for="m-address">Email</label>
                            <p class="grid--cell s-description">Required, but never shown</p>
                        </div>
                    </div>
                    <div class="grid ps-relative">
                        <input class="s-input" id="m-address" name="m-address" type="text" value="" size="40" tabindex="106" placeholder="" />
                    </div>
                </div>
            </div>

            </noscript>

                            </div>

                                                            <div class="form-submit cbt grid gsx gs4">
                                    <button id="submit-button" class="grid--cell s-btn s-btn__primary s-btn__icon" type="submit" tabindex="120" autocomplete="off">
Post Your Answer                                    </button>
                                    <button class="grid--cell s-btn s-btn__danger discard-answer dno">
                                        Discard
                                    </button>
                                        <p class="privacy-policy-agreement">
                                            By clicking &quot;Post Your Answer&quot;, you agree to our <a href='https://stackoverflow.com/legal/terms-of-service/public' name='tos' target='_blank' class='-link'>terms of service</a>, <a href='https://stackoverflow.com/legal/privacy-policy' name='privacy' target='_blank' class='-link'>privacy policy</a> and <a href='https://stackoverflow.com/legal/cookie-policy' name='cookie' target='_blank' class='-link'>cookie policy</a><input type="hidden" name="legalLinksShown" value="1" />
                                        </p>
                                </div>
                        </form>



                        <h2 class="bottom-notice" data-loc="1">
Not the answer you&#39;re looking for?                            Browse other questions tagged <a href="/questions/tagged/javascript" class="post-tag" title="show questions tagged &#39;javascript&#39;" rel="tag">javascript</a> <a href="/questions/tagged/node.js" class="post-tag" title="show questions tagged &#39;node.js&#39;" rel="tag">node.js</a>  or <a href="/questions/ask">ask your own question</a>.                        </h2>
            </div>
        </div>
                <div id="sidebar" class="show-votes" role="complementary" aria-label="sidebar">
                            <div class="module question-stats">
                    <table id="qinfo">
                        <tr>
                            <td>
                                <p class="label-key">asked</p>
                            </td>
                            <td style="padding-left: 10px">
                                <p class="label-key" title="2011-08-09 15:04:13Z">
                                    <b>
                                        <time itemprop="dateCreated" datetime="2011-08-09T15:04:13">7 years, 7 months ago</time>
                                    </b>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p class="label-key">viewed</p>
                            </td>

                            <td style="padding-left: 10px">
                                <p class="label-key">
<span id="tm-views">84237</span> times                                </p>
                            </td>
                        </tr>
                            <tr>
                                <td>
                                    <p class="label-key">active</p>
                                </td>
                                <td style="padding-left: 10px">
                                    <p class="label-key"><b><a href="?lastactivity" class="lastactivity-link" title="2019-03-15 04:58:03Z">16 days ago</a></b></p>
                                </td>
                            </tr>
                    </table>
                </div>
            <div class="module community-bulletin" data-tracker="cb=1">
    <div class="related">
                <div class="bulletin-title">
                    Blog
                </div>
                <hr />
    <div class="spacer">
        <div class="bulletin-item-type">
                <a href="https://stackoverflow.blog/2019/03/28/the-next-ceo-of-stack-overflow/" class="question-hyperlink" data-ga="[&quot;community bulletin board&quot;,&quot;Blog&quot;,&quot;https://stackoverflow.blog/2019/03/28/the-next-ceo-of-stack-overflow/&quot;,null,null]">
<div class="favicon favicon-stackexchangemeta" title="Meta Stack Exchange"></div>                </a>
        </div>
        <div class="bulletin-item-content">
            <a href="https://stackoverflow.blog/2019/03/28/the-next-ceo-of-stack-overflow/" class="question-hyperlink" data-ga="[&quot;community bulletin board&quot;,&quot;Blog&quot;,&quot;https://stackoverflow.blog/2019/03/28/the-next-ceo-of-stack-overflow/&quot;,null,null]">The Next CEO of Stack Overflow</a>
        </div>
        <br class="cbt" />
    </div>
    </div>
</div>
<div id="dfp-tsb" class="everyonelovesstackoverflow everyoneloves__top-sidebar"></div>
            <div id="hireme"></div>
<script>;try{(function(a){function b(a){return'string'==typeof a?document.getElementById(a):a}function c(a){return a=b(a),!!a&&'none'===getComputedStyle(a).display}function d(a){return!c(a)}function e(a){return!!a}function f(a){return /^\s*$/.test(b(a).innerHTML)}function g(a){var b=a.style;b.height=b.maxHeight=b.minHeight='auto',b.display='none',[].forEach.call(a.children,g)}function h(a,b){var c;return function(){return a&&(c=a.call(b||this,arguments),a=null),c}}function i(a){var b=document.createElement('script');b.src=a,document.body.appendChild(b)}function j(a){return k([],a)}function k(a,b){return a.push=function(a){return b(),delete this.push,this.push(a)},a}function l(){try{return!new Function('return async()=>{};')}catch(a){return!0}}function m(){return'undefined'!=typeof googletag&&!!googletag.apiReady}function n(){m()||(googletag={cmd:j(A)})}function o(){var a=document.createElement('div');a.className='adsbox',a.id='clc-abd',a.style.position='absolute',a.style.pointerEvents='none',a.innerHTML='&nbsp;',document.body.appendChild(a)}function p(a){var b=a.serviceName,c=a.slot,d=a.lineItemId;try{var e=c.getSlotElementId(),f=[];e||f.push('id=0');var h=document.getElementById(e);if(!e||h?h.hasAttribute('data-clc-stalled')&&f.push('st=1'):f.push('el=0'),0!==f.length)return void B(f.join('&'));-1===x.dh.indexOf(d)?h.setAttribute('data-clc-prefilled','true'):g(h),h.setAttribute('data-clc-ready','true')}catch(a){var i=document.querySelector('#dfp-tsb, #dfp-isb, #clc-tsb');i&&i.setAttribute('data-clc-ready','true'),B('e=1')}}function q(){return Object.keys(F.ids)}function r(a){var b=F.ids[a],c=F.slots[b];'function'==typeof c&&(c=c(a));return{path:'/'+C+'/'+E+'/'+b+'/'+D,sizes:c,zone:b}}function s(a){return!(clc.collapse&&void 0!==clc.collapse[a])||!!clc.collapse[a]}function t(a,b){'dfp-isb'===a&&b.setTargeting('Sidebar',['Inline']),'dfp-tsb'===a&&b.setTargeting('Sidebar',['Right']);var c=r(a),d=c.path,e=c.sizes,f=c.zone,g=googletag.defineSlot(d,e,a);s(f)&&g.setCollapseEmptyDiv(!0,!0),g.addService(b),!1}function u(b){var c=a.dfp&&a.dfp.targeting||{};Object.keys(c).forEach(function(a){b.setTargeting(a,c[a])})}function v(a){var g=a.map(b).filter(e);return{eligible:g.filter(f).filter(d).map(function(a){return a.id}),ineligible:g.filter(c)}}function w(b){if(void 0===b&&(b=q()),!m())return n(),void googletag.cmd.push(function(){return w(b)});var c=v(b),d=c.eligible,e=c.ineligible;if(e.forEach(g),0!==d.length){o(),googletag.destroySlots();var f=googletag.pubads();f.enableSingleRequest(),a.sreEvent||(f.addEventListener('slotRenderEnded',p),a.sreEvent=!0),u(f),d.forEach(function(a){return t(a,f)}),googletag.enableServices(),d.forEach(function(a){googletag.display(a)})}}var x=function(a){for(var b=[],c=1;c<arguments.length;c++)b[c-1]=arguments[c];for(var d,e=0,f=b;e<f.length;e++)for(var g in d=f[e],d)a[g]=d[g];return a}({"lib":"https://cdn.sstatic.net/clc/clc.min.js?v=04d772c81312","style":"https://cdn.sstatic.net/clc/styles/clc.min.css?v=768595a6d237","u":"https://clc.stackoverflow.com/markup.js","wa":true,"kt":2000,"tto":true,"h":"clc.stackoverflow.com","allowed":"^(((talent\\.)?stackoverflow)|(blog\\.codinghorror)|(serverfault|askubuntu)|([^\\.]+\\.stackexchange))\\.com$","wv":true,"al":false,"dh":[4385506061,4386578282,4386579572]},a.options||{}),y=h(function(){var a=x.lib;l()&&(a=a.replace(/(\.min)?\.js(\?v=[0-9a-fA-F]+)?$/,'.ie$1.js$2')),i(a)}),z=a.cmd||[];Array.isArray(z)&&(0<z.length?y():k(z,y));var A=h(function(){i('https://www.googletagservices.com/tag/js/gpt.js')}),B=function(a){new Image().src='https://'+x.h+'/stalled.gif?'+a},C='248424177',D=/^\/tags\//.test(location.pathname)||/^\/questions\/tagged\//.test(location.pathname)?'tag-pages':'question-pages',E=location.hostname;var F={slots:{lb:[[728,90]],mlb:[[728,90]],smlb:[[728,90]],bmlb:[[728,90]],sb:function(a){return'dfp-tsb'===a?[[300,250],[300,600]]:[[300,250]]},"tag-sponsorship":[[730,135]],"mobile-below-question":[[320,50],[300,250]]},ids:{"dfp-tlb":'lb',"dfp-mlb":'mlb',"dfp-smlb":'smlb',"dfp-bmlb":'bmlb',"dfp-tsb":'sb',"dfp-isb":'sb',"dfp-tag":'tag-sponsorship',"dfp-m-aq":'mobile-below-question',"clc-tlb":'lb',"clc-mlb":'mlb',"clc-tsb":'sb'}};(function(){var b=x.al;b&&z.push(function(){return a.load()})})(),n(),a.dfp={load:w},a.options=x,a.cmd=z})(this.clc=this.clc||{})}catch(a){window.console.error(a)}</script>            <script>
                var clc = clc || {};
                clc.collapse = { sb: !0,'tag-sponsorship':!0,lb:!1,mlb:!1,smlb:!1,bmlb:!1,'mobile-below-question':!0};
                clc.cmd = clc.cmd || [];
                clc.cmd.push(function () { window.clc_request='Ap5QMAPwtdYIAAAAAFPJagACAAAAAgAAAAAUAAAAfGphdmFzY3JpcHR8bm9kZS5qc3wA4o-I375kV-CAgw'; clc.load(); });
                                clc.dfp = clc.dfp || {};
                clc.dfp.targeting = {Registered:['false'],'so-tag':['javascript','node.js'],Persona:['Cloud']};
                
                var googletag = googletag || {};
                googletag.cmd = googletag.cmd || [];
                googletag.cmd.push(function () { clc.dfp.load(); });
            </script><div class="s-sidebarwidget mb16 module">
    <div class="s-sidebarwidget--header grid ai-center">
        <a href="https://chat.stackoverflow.com" class="js-chat-ad-link">Visit chat</a>
    </div>
        <div class="s-sidebarwidget--content s-sidebarwidget__items d-none js-chat-ad-rooms"></div>
</div>


    <script>
    // <!--
        StackExchange.ready(function () {
            var options = {
                chatUrl: 'https://chat.stackoverflow.com',
                reloadUrl: '/api/recent-chat',
                preloadedData: null,
                tagBased: true,
            };

            StackExchange.chatAd.init(options);
        });
    // -->
    </script>
            <div class="module sidebar-linked">
	<h4 id="h-linked">Linked</h4>
	<div class="linked" data-tracker="lq=1">

<div class="spacer">
	<a href="/q/40420191" title="Vote score (upvotes - downvotes)">
		<div class="answer-votes  default">0</div>
	</a>
	<a href="/questions/40420191/how-to-include-one-js-file-into-another-in-node-js?noredirect=1" class="question-hyperlink">How to include one .js file into another in Node.js?</a>
</div>			</div>
</div>

                <div class="module sidebar-related">
                    <h4 id="h-related">Related</h4>
                    <div class="related js-gps-related-questions" data-tracker="rq=1">
                        <div class="spacer"><a href="/q/195951" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">2485</div></a><a href="/questions/195951/how-to-change-an-elements-class-with-javascript" class="question-hyperlink">How to change an element&#39;s class with JavaScript?</a></div><div class="spacer"><a href="/q/208105" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">5433</div></a><a href="/questions/208105/how-do-i-remove-a-property-from-a-javascript-object" class="question-hyperlink">How do I remove a property from a JavaScript object?</a></div><div class="spacer"><a href="/q/237104" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">3508</div></a><a href="/questions/237104/how-do-i-check-if-an-array-includes-an-object-in-javascript" class="question-hyperlink">How do I check if an array includes an object in JavaScript?</a></div><div class="spacer"><a href="/q/281264" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted large">850</div></a><a href="/questions/281264/remove-empty-elements-from-an-array-in-javascript" class="question-hyperlink">Remove empty elements from an array in Javascript</a></div><div class="spacer"><a href="/q/950087" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">4551</div></a><a href="/questions/950087/how-do-i-include-a-javascript-file-in-another-javascript-file" class="question-hyperlink">How do I include a JavaScript file in another JavaScript file?</a></div><div class="spacer"><a href="/q/2496710" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">1358</div></a><a href="/questions/2496710/writing-files-in-node-js" class="question-hyperlink">Writing files in Node.js</a></div><div class="spacer"><a href="/q/4482686" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted large">988</div></a><a href="/questions/4482686/check-synchronously-if-file-directory-exists-in-node-js" class="question-hyperlink">Check synchronously if file/directory exists in Node.js</a></div><div class="spacer"><a href="/q/5767325" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">6957</div></a><a href="/questions/5767325/how-do-i-remove-a-particular-element-from-an-array-in-javascript" class="question-hyperlink">How do I remove a particular element from an array in JavaScript?</a></div><div class="spacer"><a href="/q/5797852" title="Vote score (upvotes - downvotes)"><div class="answer-votes large">803</div></a><a href="/questions/5797852/in-node-js-how-do-i-include-functions-from-my-other-files" class="question-hyperlink">In Node.js, how do I &ldquo;include&rdquo; functions from my other files?</a></div><div class="spacer"><a href="/q/11177954" title="Vote score (upvotes - downvotes)"><div class="answer-votes answered-accepted extra-large">1045</div></a><a href="/questions/11177954/how-do-i-completely-uninstall-node-js-and-reinstall-from-beginning-mac-os-x" class="question-hyperlink">How do I completely uninstall Node.js, and reinstall from beginning (Mac OS X)</a></div>
                    </div>
                </div>

<div id="hot-network-questions" class="module tex2jax_ignore">
    <h4>
        <a href="https://stackexchange.com/questions?tab=hot"
           class="js-gps-track s-link s-link__inherit" 
           data-gps-track="posts_hot_network.click({ item_type:1, location:11 })">
            Hot Network Questions
        </a>
    </h4>
    <ul>
            <li >
                <div class="favicon favicon-law" title="Law Stack Exchange"></div><a href="https://law.stackexchange.com/questions/38619/defamation-due-to-breach-of-confidentiality" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:617 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Defamation due to breach of confidentiality
                </a>

            </li>
            <li >
                <div class="favicon favicon-codereview" title="Code Review Stack Exchange"></div><a href="https://codereview.stackexchange.com/questions/216534/easy-to-read-palindrome-checker" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:196 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Easy to read palindrome checker
                </a>

            </li>
            <li >
                <div class="favicon favicon-mechanics" title="Motor Vehicle Maintenance &amp; Repair Stack Exchange"></div><a href="https://mechanics.stackexchange.com/questions/65044/getting-stale-gas-out-of-a-gas-tank-w-out-dropping-the-tank" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:224 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Getting Stale Gas Out of a Gas Tank w/out Dropping the Tank
                </a>

            </li>
            <li >
                <div class="favicon favicon-ham" title="Amateur Radio Stack Exchange"></div><a href="https://ham.stackexchange.com/questions/13157/rigexpert-aa-35-interpreting-the-information" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:520 }); posts_hot_network.click({ item_type:2, location:11 })">
                    RigExpert AA-35 - Interpreting The Information
                </a>

            </li>
            <li >
                <div class="favicon favicon-tex" title="TeX - LaTeX Stack Exchange"></div><a href="https://tex.stackexchange.com/questions/482404/how-to-properly-draw-diagonal-line-while-using-multicolumn-inside-tabular-enviro" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:85 }); posts_hot_network.click({ item_type:2, location:11 })">
                    How to properly draw diagonal line while using multicolumn inside tabular environment?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-scifi" title="Science Fiction &amp; Fantasy Stack Exchange"></div><a href="https://scifi.stackexchange.com/questions/208067/why-didnt-khan-get-resurrected-in-the-genesis-explosion" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:186 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Why didn&#39;t Khan get resurrected in the Genesis Explosion?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-german" title="German Language Stack Exchange"></div><a href="https://german.stackexchange.com/questions/50408/can-i-use-the-word-senior-directly-in-german" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:253 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Can I use the word &quot;Senior&quot; directly in German?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-photo" title="Photography Stack Exchange"></div><a href="https://photo.stackexchange.com/questions/106270/how-many-extra-stops-do-monopods-offer-for-tele-photographs" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:61 }); posts_hot_network.click({ item_type:2, location:11 })">
                    How many extra stops do monopods offer for tele photographs?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-writing" title="Writing Stack Exchange"></div><a href="https://writing.stackexchange.com/questions/44203/is-wanting-to-ask-what-to-write-an-indication-that-you-need-to-change-your-story" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:166 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Is wanting to ask what to write an indication that you need to change your story?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-english" title="English Language &amp; Usage Stack Exchange"></div><a href="https://english.stackexchange.com/questions/492016/when-be-it-is-at-the-beginning-of-a-sentence-what-kind-of-structure-do-you-ca" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:97 }); posts_hot_network.click({ item_type:2, location:11 })">
                    When &quot;be it&quot; is at the beginning of a sentence, what kind of structure do you call it?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-hinduism" title="Hinduism Stack Exchange"></div><a href="https://hinduism.stackexchange.com/questions/34110/do-scriptures-give-a-method-to-recognize-a-truly-self-realized-person-jivanmukta" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:567 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Do scriptures give a method to recognize a truly self-realized person/jivanmukta?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-music" title="Music: Practice &amp; Theory Stack Exchange"></div><a href="https://music.stackexchange.com/questions/82164/bartok-syncopation-1-meaning-of-notes-in-between-grand-staff" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:240 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Bartok - Syncopation (1): Meaning of notes in between Grand Staff
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-unix" title="Unix &amp; Linux Stack Exchange"></div><a href="https://unix.stackexchange.com/questions/509583/is-it-possible-to-replace-duplicates-of-a-character-with-one-character-using-tr" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:106 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Is it possible to replace duplicates of a character with one character using tr
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-english" title="English Language &amp; Usage Stack Exchange"></div><a href="https://english.stackexchange.com/questions/492045/is-three-point-ish-an-acceptable-use-of-ish" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:97 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Is &quot;three point ish&quot; an acceptable use of ish?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-physics" title="Physics Stack Exchange"></div><a href="https://physics.stackexchange.com/questions/469598/0-rank-tensor-vs-vector-in-1d" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:151 }); posts_hot_network.click({ item_type:2, location:11 })">
                    0-rank tensor vs vector in 1D
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-politics" title="Politics Stack Exchange"></div><a href="https://politics.stackexchange.com/questions/39963/why-is-the-us-ranked-as-45-in-press-freedom-ratings-despite-its-extremely-perm" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:475 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Why is the US ranked as #45 in Press Freedom ratings, despite its extremely permissive free speech laws?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-music" title="Music: Practice &amp; Theory Stack Exchange"></div><a href="https://music.stackexchange.com/questions/82171/what-is-meant-by-large-scale-tonal-organization" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:240 }); posts_hot_network.click({ item_type:2, location:11 })">
                    What is meant by &quot;large scale tonal organization?&quot;
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-softwareengineering" title="Software Engineering Stack Exchange"></div><a href="https://softwareengineering.stackexchange.com/questions/389445/why-dont-programming-languages-automatically-manage-the-synchronous-asynchronou" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:131 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Why don&#39;t programming languages automatically manage the synchronous/asynchronous problem?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-apple" title="Ask Different"></div><a href="https://apple.stackexchange.com/questions/355277/my-ex-girlfriend-uses-my-apple-id-to-login-to-her-ipad-do-i-have-to-give-her-my" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:118 }); posts_hot_network.click({ item_type:2, location:11 })">
                    My ex-girlfriend uses my Apple ID to login to her iPad, do I have to give her my Apple ID password to reset it?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-writing" title="Writing Stack Exchange"></div><a href="https://writing.stackexchange.com/questions/44211/is-it-okay-to-majorly-distort-historical-facts-while-writing-a-fiction-story" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:166 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Is it okay to majorly distort historical facts while writing a fiction story?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-german" title="German Language Stack Exchange"></div><a href="https://german.stackexchange.com/questions/50363/is-there-a-difference-between-fahrstuhl-and-aufzug" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:253 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Is there a difference between &quot;Fahrstuhl&quot; and &quot;Aufzug&quot;?
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-tex" title="TeX - LaTeX Stack Exchange"></div><a href="https://tex.stackexchange.com/questions/482435/draw-arrow-between-venn-diagrams" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:85 }); posts_hot_network.click({ item_type:2, location:11 })">
                    Draw arrow between Venn diagrams
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-money" title="Personal Finance &amp; Money Stack Exchange"></div><a href="https://money.stackexchange.com/questions/107058/i-believe-this-to-be-fraud-hired-then-asked-to-cash-check-and-send-cash-as-bi" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:93 }); posts_hot_network.click({ item_type:2, location:11 })">
                    I believe this to be fraud — hired, then asked to cash check and send cash as Bitcoin
                </a>

            </li>
            <li class="dno js-hidden">
                <div class="favicon favicon-ell" title="English Language Learners Stack Exchange"></div><a href="https://ell.stackexchange.com/questions/203227/what-can-the-phrase-is-embedded-in-a-whale-of-a-bill-mean" class="js-gps-track question-hyperlink mb0" data-gps-track="site.switch({ item_type:11, target_site:481 }); posts_hot_network.click({ item_type:2, location:11 })">
                    What can the phrase “is embedded in a whale of a bill” mean?
                </a>

            </li>
    </ul>

        <a href="#" 
           class="show-more js-show-more js-gps-track" 
           data-gps-track="posts_hot_network.click({ item_type:3, location:11 })">
            more hot questions
        </a>
</div>

<div id="feed-link">
    <a href="/feeds/question/6998355" title="feed of this question and its answers">
        <svg aria-hidden="true" class="svg-icon fc-orange-400 iconRss" width="18" height="18" viewBox="0 0 18 18"><path d="M1 3c0-1.1.9-2 2-2h12a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V3zm14.5 12C15.5 8.1 9.9 2.5 3 2.5V5a10 10 0 0 1 10 10h2.5zm-5 0A7.5 7.5 0 0 0 3 7.5V10a5 5 0 0 1 5 5h2.5zm-5 0A2.5 2.5 0 0 0 3 12.5V15h2.5z"/></svg>
        question feed
    </a>
</div>
        </div>
    </div>
<script>StackExchange.ready(function(){$.get('/posts/6998355/ivc/20d7');});</script>
<noscript><div><img src="/posts/6998355/ivc/20d7" class="dno" alt="" width="0" height="0"></div></noscript><div style="display:none" id="prettify-lang">lang-js</div></div>


        </div>
    </div>

    <footer id="footer" class="site-footer js-footer" role="contentinfo">
        <div class="site-footer--container">
                <div class="site-footer--logo">

                    
                    <a href="https://stackoverflow.com"><svg aria-hidden="true" class="svg-icon native iconLogoGlyphMd" width="32" height="37" viewBox="0 0 32 37"><g><path fill="#BCBBBB" d="M26 33v-9h4v13H0V24h4v9z"/><path d="M23.1 25.99l.68-2.95-16.1-3.35L7 23l16.1 2.99zM9.1 15.2l15 7 1.4-3-15-7-1.4 3zm4.2-7.4L26 18.4l2.1-2.5L15.4 5.3l-2.1 2.5zM21.5 0l-2.7 2 9.9 13.3 2.7-2L21.5 0zM7 30h16v-3H7v3z" fill="#F48024"/></g></svg></a>
                </div>
            
            <nav class="site-footer--nav">
                    <div class="site-footer--col site-footer--col__visible js-footer-col" data-name="default">
                        <h5 class="-title"><a href="https://stackoverflow.com" class="js-gps-track" data-gps-track="footer.click({ location: 2, link: 15})">Stack Overflow</a></h5>
                        <ul class="-list js-primary-footer-links">
                            <li class="-item"><a href="/questions" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 16})">Questions</a></li>
                                <li class="-item"><a href="https://stackoverflow.com/jobs" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 17})">Jobs</a></li>
                                <li class="-item"><a href="https://stackoverflow.com/jobs/directory/developer-jobs" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 11})">Developer Jobs Directory</a></li>
                                     <li class="-item"><a href="https://stackoverflow.com/jobs/salary" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 28})">Salary Calculator</a></li>
                                                            <li class="-item"><a href="/help" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 3 })">Help</a></li>
                                <li class="-item"><a onclick='StackExchange.switchMobile("on")' class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 12 })">Mobile</a></li>
                        </ul>
                    </div>
                    <div class="site-footer--col site-footer--col__visible js-footer-col" data-name="default">
                        <h5 class="-title"><a href="https://www.stackoverflowbusiness.com" class="js-gps-track" data-gps-track="footer.click({ location: 2, link: 19 })">Products</a></h5>
                        <ul class="-list">
                            <li class="-item"><a href="https://stackoverflow.com/teams" class="js-gps-track -link" 
                                                 data-ga="[&quot;teams traffic&quot;,&quot;footer - site nav&quot;,&quot;stackoverflow.com/teams&quot;,null,{&quot;dimension4&quot;:&quot;teams&quot;}]"
                                                 data-gps-track="footer.click({ location: 2, link: 29 })">Teams</a></li>
                            <li class="-item"><a href="https://www.stackoverflowbusiness.com/talent" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 20 })">Talent</a></li>
                            <li class="-item"><a href="https://www.stackoverflowbusiness.com/advertising" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 21 })">Advertising</a></li>
                            <li class="-item"><a href="https://stackoverflow.com/enterprise" class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 22 })">Enterprise</a></li>
                        </ul>
                    </div>
                <div class="site-footer--col site-footer--col__visible js-footer-col" data-name="default">
                    <h5 class="-title"><a class="js-gps-track" data-gps-track="footer.click({ location: 2, link: 1 })" href="https://stackoverflow.com/company/about">Company</a></h5>
                    <ul class="-list">
                            <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 1 })" href="https://stackoverflow.com/company/about">About</a></li>
                                                <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 27 })" href="https://stackoverflow.com/company/press">Press</a></li>
                            <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 9 })" href="https://stackoverflow.com/company/work-here">Work Here</a></li>
                        <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 7 })" href="https://stackoverflow.com/legal">Legal</a></li>
                        <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 8 })" href="https://stackoverflow.com/legal/privacy-policy">Privacy Policy</a></li>
                            <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link: 13 })" href="https://stackoverflow.com/company/contact">Contact Us</a></li>
                    </ul>
                </div>
                <div class="site-footer--col site-footer--categories-nav site-footer--col__visible">
                    <a href="#" class="site-footer--back js-footer-back"><svg aria-hidden="true" class="svg-icon iconArrowLeftAlt" width="18" height="18" viewBox="0 0 18 18"><path d="M10.58 16L12 14.59 6.4 9 12 3.41 10.57 2l-7 7z"/></svg></a>
                    <div>
                        <h5 class="-title"><a href="https://stackexchange.com">Stack Exchange<br> Network</a></h5>
                        <ul class="-list">
                            <li class="-item"><a href="#" class="-link _expandable js-footer-category-trigger js-gps-track" data-gps-track="footer.click({ location: 2, link: 24 })" data-target="Technology">Technology</a></li>
                            <li class="-item"><a href="#" class="-link _expandable js-footer-category-trigger js-gps-track" data-gps-track="footer.click({ location: 2, link: 24 })" data-target="Life / Arts">Life / Arts</a></li>
                            <li class="-item"><a href="#" class="-link _expandable js-footer-category-trigger js-gps-track" data-gps-track="footer.click({ location: 2, link: 24 })" data-target="Culture / Recreation">Culture / Recreation</a></li>
                            <li class="-item"><a href="#" class="-link _expandable js-footer-category-trigger js-gps-track" data-gps-track="footer.click({ location: 2, link: 24 })" data-target="Science">Science</a></li>
                            <li class="-item"><a href="#" class="-link _expandable js-footer-category-trigger js-gps-track" data-gps-track="footer.click({ location: 2, link: 24 })" data-target="Other">Other</a></li>

                        </ul>
                    </div>
                </div>
                <div class="site-footer--categories">
                    <div class="site-footer--col site-footer--category js-footer-col" data-name="Technology">
        <ul class="-list">
                <li class="-item"><a href="https://stackoverflow.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professional and enthusiast programmers">Stack Overflow</a></li>
                <li class="-item"><a href="https://serverfault.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="system and network administrators">Server Fault</a></li>
                <li class="-item"><a href="https://superuser.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="computer enthusiasts and power users">Super User</a></li>
                <li class="-item"><a href="https://webapps.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="power users of web applications">Web Applications</a></li>
                <li class="-item"><a href="https://askubuntu.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Ubuntu users and developers">Ask Ubuntu</a></li>
                <li class="-item"><a href="https://webmasters.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="pro webmasters">Webmasters</a></li>
                <li class="-item"><a href="https://gamedev.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professional and independent game developers">Game Development</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Technology"><ul class="-list">
                <li class="-item"><a href="https://tex.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users of TeX, LaTeX, ConTeXt, and related typesetting systems">TeX - LaTeX</a></li>
                <li class="-item"><a href="https://softwareengineering.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professionals, academics, and students working within the systems development life cycle">Software Engineering</a></li>
                <li class="-item"><a href="https://unix.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users of Linux, FreeBSD and other Un*x-like operating systems">Unix &amp; Linux</a></li>
                <li class="-item"><a href="https://apple.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="power users of Apple hardware and software">Ask Different (Apple)</a></li>
                <li class="-item"><a href="https://wordpress.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="WordPress developers and administrators">WordPress Development</a></li>
                <li class="-item"><a href="https://gis.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="cartographers, geographers and GIS professionals">Geographic Information Systems</a></li>
                <li class="-item"><a href="https://electronics.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="electronics and electrical engineering professionals, students, and enthusiasts">Electrical Engineering</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Technology"><ul class="-list">
                <li class="-item"><a href="https://android.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="enthusiasts and power users of the Android operating system">Android Enthusiasts</a></li>
                <li class="-item"><a href="https://security.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="information security professionals">Information Security</a></li>
                <li class="-item"><a href="https://dba.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="database professionals who wish to improve their database skills and learn from others in the community">Database Administrators</a></li>
                <li class="-item"><a href="https://drupal.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Drupal developers and administrators">Drupal Answers</a></li>
                <li class="-item"><a href="https://sharepoint.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="SharePoint enthusiasts">SharePoint</a></li>
                <li class="-item"><a href="https://ux.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="user experience researchers and experts">User Experience</a></li>
                <li class="-item"><a href="https://mathematica.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users of Wolfram Mathematica">Mathematica</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Technology"><ul class="-list">
                <li class="-item"><a href="https://salesforce.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Salesforce administrators, implementation experts, developers and anybody in-between">Salesforce</a></li>
                <li class="-item"><a href="https://expressionengine.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="administrators, end users, developers and designers for ExpressionEngine&#174; CMS">ExpressionEngine&#174; Answers</a></li>
                <li class="-item"><a href="https://pt.stackoverflow.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="programadores profissionais e entusiastas">Stack Overflow em Portugu&#234;s</a></li>
                <li class="-item"><a href="https://blender.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people who use Blender to create 3D graphics, animations, or games">Blender</a></li>
                <li class="-item"><a href="https://networkengineering.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="network engineers">Network Engineering</a></li>
                <li class="-item"><a href="https://crypto.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="software developers, mathematicians and others interested in cryptography">Cryptography</a></li>
                <li class="-item"><a href="https://codereview.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="peer programmer code reviews">Code Review</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Technology"><ul class="-list">
                <li class="-item"><a href="https://magento.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users of the Magento e-Commerce platform">Magento</a></li>
                <li class="-item"><a href="https://softwarerecs.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people seeking specific software recommendations">Software Recommendations</a></li>
                <li class="-item"><a href="https://dsp.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="practitioners of the art and science of signal, image and video processing">Signal Processing</a></li>
                <li class="-item"><a href="https://emacs.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="those using, extending or developing Emacs">Emacs</a></li>
                <li class="-item"><a href="https://raspberrypi.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users and developers of hardware and software for Raspberry Pi">Raspberry Pi</a></li>
                <li class="-item"><a href="https://ru.stackoverflow.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="программистов">Stack Overflow на русском</a></li>
                <li class="-item"><a href="https://codegolf.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="programming puzzle enthusiasts and code golfers">Programming Puzzles &amp; Code Golf</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Technology"><ul class="-list">
                <li class="-item"><a href="https://es.stackoverflow.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="programadores y profesionales de la inform&#225;tica">Stack Overflow en espa&#241;ol</a></li>
                <li class="-item"><a href="https://ethereum.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="users of Ethereum, the decentralized application platform and smart contract enabled blockchain">Ethereum</a></li>
                <li class="-item"><a href="https://datascience.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Data science professionals, Machine Learning specialists, and those interested in learning more about the field">Data Science</a></li>
                <li class="-item"><a href="https://arduino.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="developers of open-source hardware and software that is compatible with Arduino">Arduino</a></li>
                <li class="-item"><a href="https://bitcoin.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Bitcoin crypto-currency enthusiasts">Bitcoin</a></li>
                            <li class="-item">
                    <a href="https://stackexchange.com/sites#technology" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 26 })">
                        <strong>
                            more (31)
                        </strong>
                    </a>
                </li>
        </ul>
    </div>
    <div class="site-footer--col site-footer--category js-footer-col" data-name="Life / Arts">
        <ul class="-list">
                <li class="-item"><a href="https://photo.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professional, enthusiast and amateur photographers">Photography</a></li>
                <li class="-item"><a href="https://scifi.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="science fiction and fantasy enthusiasts">Science Fiction &amp; Fantasy</a></li>
                <li class="-item"><a href="https://graphicdesign.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="Graphic Design professionals, students, and enthusiasts">Graphic Design</a></li>
                <li class="-item"><a href="https://movies.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="movie and tv enthusiasts">Movies &amp; TV</a></li>
                <li class="-item"><a href="https://music.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="musicians, students, and enthusiasts">Music: Practice &amp; Theory</a></li>
                <li class="-item"><a href="https://worldbuilding.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="writers/artists using science, geography and culture to construct imaginary worlds and settings">Worldbuilding</a></li>
                <li class="-item"><a href="https://cooking.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professional and amateur chefs">Seasoned Advice (cooking)</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Life / Arts"><ul class="-list">
                <li class="-item"><a href="https://diy.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="contractors and serious DIYers">Home Improvement</a></li>
                <li class="-item"><a href="https://money.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people who want to be financially literate">Personal Finance &amp; Money</a></li>
                <li class="-item"><a href="https://academia.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="academics and those enrolled in higher education">Academia</a></li>
                <li class="-item"><a href="https://law.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="legal professionals, students, and others with experience or interest in law">Law</a></li>
                            <li class="-item">
                    <a href="https://stackexchange.com/sites#lifearts" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 26 })">
                        <strong>
                            more (15)
                        </strong>
                    </a>
                </li>
        </ul>
    </div>
    <div class="site-footer--col site-footer--category js-footer-col" data-name="Culture / Recreation">
        <ul class="-list">
                <li class="-item"><a href="https://english.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="linguists, etymologists, and serious English language enthusiasts">English Language &amp; Usage</a></li>
                <li class="-item"><a href="https://skeptics.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="scientific skepticism">Skeptics</a></li>
                <li class="-item"><a href="https://judaism.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="those who base their lives on Jewish law and tradition and anyone interested in learning more">Mi Yodeya (Judaism)</a></li>
                <li class="-item"><a href="https://travel.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="road warriors and seasoned travelers">Travel</a></li>
                <li class="-item"><a href="https://christianity.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="committed Christians, experts in Christianity and those interested in learning more">Christianity</a></li>
                <li class="-item"><a href="https://ell.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="speakers of other languages learning English">English Language Learners</a></li>
                <li class="-item"><a href="https://japanese.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="students, teachers, and linguists wanting to discuss the finer points of the Japanese language">Japanese Language</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Culture / Recreation"><ul class="-list">
                <li class="-item"><a href="https://gaming.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="passionate videogamers on all platforms">Arqade (gaming)</a></li>
                <li class="-item"><a href="https://bicycles.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people who build and repair bicycles, people who train cycling, or commute on bicycles">Bicycles</a></li>
                <li class="-item"><a href="https://rpg.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="gamemasters and players of tabletop, paper-and-pencil role-playing games">Role-playing Games</a></li>
                <li class="-item"><a href="https://anime.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="anime and manga fans">Anime &amp; Manga</a></li>
                <li class="-item"><a href="https://puzzling.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="those who create, solve, and study puzzles">Puzzling</a></li>
                <li class="-item"><a href="https://mechanics.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="mechanics and DIY enthusiast owners of cars, trucks, and motorcycles">Motor Vehicle Maintenance &amp; Repair</a></li>
                            <li class="-item">
                    <a href="https://stackexchange.com/sites#culturerecreation" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 26 })">
                        <strong>
                            more (33)
                        </strong>
                    </a>
                </li>
        </ul>
    </div>
    <div class="site-footer--col site-footer--category js-footer-col" data-name="Science">
        <ul class="-list">
                <li class="-item"><a href="https://mathoverflow.net" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="professional mathematicians">MathOverflow</a></li>
                <li class="-item"><a href="https://math.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people studying math at any level and professionals in related fields">Mathematics</a></li>
                <li class="-item"><a href="https://stats.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="people interested in statistics, machine learning, data analysis, data mining, and data visualization">Cross Validated (stats)</a></li>
                <li class="-item"><a href="https://cstheory.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="theoretical computer scientists and researchers in related fields">Theoretical Computer Science</a></li>
                <li class="-item"><a href="https://physics.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="active researchers, academics and students of physics">Physics</a></li>
                <li class="-item"><a href="https://chemistry.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="scientists, academics, teachers, and students in the field of chemistry">Chemistry</a></li>
                <li class="-item"><a href="https://biology.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="biology researchers, academics, and students">Biology</a></li>
                    </ul></div><div class="site-footer--col site-footer--category js-footer-col" data-name="Science"><ul class="-list">
                <li class="-item"><a href="https://cs.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="students, researchers and practitioners of computer science">Computer Science</a></li>
                <li class="-item"><a href="https://philosophy.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="those interested in the study of the fundamental nature of knowledge, reality, and existence">Philosophy</a></li>
                            <li class="-item">
                    <a href="https://stackexchange.com/sites#science" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 26 })">
                        <strong>
                            more (10)
                        </strong>
                    </a>
                </li>
        </ul>
    </div>
    <div class="site-footer--col site-footer--category js-footer-col" data-name="Other">
        <ul class="-list">
                <li class="-item"><a href="https://meta.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="meta-discussion of the Stack Exchange family of Q&amp;A websites">Meta Stack Exchange</a></li>
                <li class="-item"><a href="https://stackapps.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="apps, scripts, and development with the Stack Exchange API">Stack Apps</a></li>
                <li class="-item"><a href="https://api.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="programmatic interaction with Stack Exchange sites">API</a></li>
                <li class="-item"><a href="https://data.stackexchange.com" class="-link js-gps-track" data-gps-track="footer.click({ location: 0, link: 25 })" title="querying Stack Exchange data using SQL">Data</a></li>
                    </ul>
    </div>
                </div>
            </nav>
            <div class="site-footer--copyright fs-fine">
                <ul class="-list">
                    <li class="-item"><a class="js-gps-track -link" data-gps-track="footer.click({ location: 2, link:4 })" href="https://stackoverflow.blog?blb=1">Blog</a></li>
                    <li class="-item"><a href="https://www.facebook.com/officialstackoverflow/" class="-link">Facebook</a></li>
                    <li class="-item"><a href="https://twitter.com/stackoverflow" class="-link">Twitter</a></li>
                    <li class="-item"><a href="https://linkedin.com/company/stack-overflow" class="-link">LinkedIn</a></li>
                </ul>

                <p class="mt-auto mb24">
site design / logo &#169; 2019 Stack Exchange Inc; user contributions licensed under <a href="https://creativecommons.org/licenses/by-sa/3.0/" rel="license">cc by-sa 3.0</a>
                            with <a href="https://stackoverflow.blog/2009/06/25/attribution-required/" rel="license">attribution required</a>.
                    <span id="svnrev">rev&nbsp;2019.3.31.33182</span>
                </p>
            </div>
        </div>

            </footer>
            <script>StackExchange.ready(function () { StackExchange.responsiveness.addSwitcher(); })</script>
    <noscript>
        <div id="noscript-warning">Stack Overflow works best with JavaScript enabled
            <img src="https://pixel.quantserve.com/pixel/p-c1rF4kxgLUzNc.gif" alt="" class="dno">
        </div>
    </noscript>

<script>
            (function(i, s, o, g, r, a, m) {
                i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function() { (i[r].q = i[r].q || []).push(arguments) }, i[r].l = 1 * new Date(); a = s.createElement(o),
                m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m);
            })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

            StackExchange.ready(function () {

                StackExchange.ga.init({
                    sendTitles: true,
                    tracker: window.ga,
                    trackingCodes: [
                        'UA-108242619-1'
                    ]
                });



                    StackExchange.ga.setDimension('dimension2', '|javascript|node.js|');

                    StackExchange.ga.setDimension('dimension3', 'Questions/Show');


                StackExchange.ga.trackPageView();
            });
            
/**/
            
            var _qevents = _qevents || [],
            _comscore = _comscore || [];
            (function() {
                var ssl = 'https:' == document.location.protocol,
                    s = document.getElementsByTagName('script')[0],
                    qc = document.createElement('script');
                 qc.async = true;
                    qc.src = (ssl ? 'https://secure' : 'http://edge') + '.quantserve.com/quant.js';
                    s.parentNode.insertBefore(qc, s);
                    _qevents.push({ qacct: "p-c1rF4kxgLUzNc" });
/**/
                 var sc = document.createElement('script');
                    sc.async = true;
                    sc.src = (ssl ? 'https://sb' : 'http://b') + '.scorecardresearch.com/beacon.js';
                    s.parentNode.insertBefore(sc, s);
                    _comscore.push({ c1: "2", c2: "17440561" });
            })();
            

</script>
            
    </body>
    </html>
