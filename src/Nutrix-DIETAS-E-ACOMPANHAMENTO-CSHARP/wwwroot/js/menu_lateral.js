let btn_menu = document.querySelector("#menubtn");
let navbar = document.querySelector("#navbar");
let user_options = document.querySelector(".user-options");

let text_icon = document.querySelector(".text-icon");
let text_icon1 = document.querySelector(".text-icon1");
let text_icon2 = document.querySelector(".text-icon2");
let text_icon3 = document.querySelector(".text-icon3");
let text_icon4 = document.querySelector(".text-icon4");
let text_icon5 = document.querySelector(".text-icon5");

let showSidebar = true;

function toggleBtnState() {
   showSidebar = !showSidebar;

    const iconsPath = {

      //openIcon: "~/assets/opened-menu-icon.png",
      //closedIcon: "~/assets/closed-menu-icon.png"
    }

   if (showSidebar == false) {
      navbar.style.width = " 2vw"
      
      // text_icon.style.marginLeft = '-100vw'
      text_icon.style.display = 'none'
      text_icon.style.animationName = ''
      // text_icon1.style.marginLeft = '-100vw'
      text_icon1.style.display = 'none'
      text_icon1.style.animationName = ''
      // text_icon2.style.marginLeft = '-100vw'
      text_icon2.style.display = 'none'
      text_icon2.style.animationName = ''
      // text_icon3.style.marginLeft = '-100vw'
      text_icon3.style.display = 'none'
      text_icon3.style.animationName = ''
      // text_icon4.style.marginLeft = '-100vw'
      text_icon4.style.display = 'none'
       text_icon4.style.animationName = ''
      // text_icon5.style.marginLeft = '-100vw'

       text_icon5.style.display = 'none'
       text_icon5.style.animationName = ''
      
      //btn_menu.setAttribute("src", iconsPath.closedIcon)

   }
   else {
      navbar.style.width = "auto"

      text_icon.style.marginLeft = '0vw'
      text_icon.style.display = 'initial'
      text_icon.style.animationName = 'showSidebar'
      text_icon1.style.marginLeft = '0vw'
      text_icon1.style.display = 'initial'
      text_icon1.style.animationName = 'showSidebar'
      text_icon2.style.marginLeft = '0vw'
      text_icon2.style.display = 'initial'
      text_icon2.style.animationName = 'showSidebar'
      text_icon3.style.marginLeft = '0vw'
      text_icon3.style.display = 'initial'
      text_icon3.style.animationName = 'showSidebar'
      text_icon4.style.marginLeft = '0vw'
      text_icon4.style.display = 'initial'
       text_icon4.style.animationName = 'showSidebar'
       text_icon5.style.marginLeft = '0vw'
       text_icon5.style.display = 'initial'
       text_icon5.style.animationName = 'showSidebar'

      //btn_menu.setAttribute("src", iconsPath.openIcon)

   }
};

let showPerfilOptions = false;



function openPerfilMenu() {
    showPerfilOptions = !showPerfilOptions

    if (showPerfilOptions == true) {
        user_options.style.display = "inline-block"
    } else {
        user_options.style.display = "none"
    }
}