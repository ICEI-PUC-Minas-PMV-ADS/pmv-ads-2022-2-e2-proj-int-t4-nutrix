let btn_menu = document.querySelector("#menubtn");
let navbar = document.querySelector(".navbar");

let showSidebar = false;

btn_menu.addEventListener('click', () => {
   showSidebar = !showSidebar;
   console.log(showSidebar)

   const iconsPath = {
      openIcon: "../../assets/opened-menu-icon.png",
      closedIcon: "../../assets/closed-menu-icon.png"
   }

   if (showSidebar) {
      navbar.style.marginLeft = '0vw'
      navbar.style.animationName = 'showSidebar'
      btn_menu.setAttribute("src", iconsPath.openIcon)
   }
   else {
      navbar.style.marginLeft = '-100vw'
      navbar.style.animationName = ''
      btn_menu.setAttribute("src", iconsPath.closedIcon)
   }
})