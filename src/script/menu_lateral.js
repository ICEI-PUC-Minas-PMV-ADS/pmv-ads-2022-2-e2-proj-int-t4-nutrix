let btn_menu = document.querySelector("#menubtn");
let navbar = document.querySelector("#navbar")
let text_icon = document.querySelector(".text-icon");

let showSidebar = true;

function toggleBtnState() {
   showSidebar = !showSidebar;
   console.log(showSidebar)

   const iconsPath = {
      openIcon: "../../assets/opened-menu-icon.png",
      closedIcon: "../../assets/closed-menu-icon.png"
   }

   if (showSidebar == false) {
      navbar.style.width = "5vw"
      text_icon.style.marginLeft = '-100vw'
      text_icon.style.animationName = ''
      btn_menu.setAttribute("src", iconsPath.closedIcon)

   }
   else {
      navbar.style.width = "10vw"
      text_icon.style.marginLeft = '0vw'
      text_icon.style.animationName = 'showSidebar'
      btn_menu.setAttribute("src", iconsPath.openIcon)

   }
};