﻿using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace TestStack.White.Repository.UITests.Testing
{
    public class BaseScreen : AppScreen
    {
        protected Button buton = null;

        public BaseScreen(Window window, ScreenRepository screenRepository) : base(window, screenRepository) { }
    }
}
