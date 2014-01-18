## Pivot is Broken

The Windows Phone 8 pivot control fails to animate in the contents of a pivot item that is replaced in the background.

### The scenario

An application loads data from a local cache. It displays the data in a pivot control. The local data just happens to have only one page.

Then the application makes an asynchronous call to fetch fresh data. The new data indicates that the original page has been deleted, and a new page has been created.

### Expected behavior

The old page is removed, and the new page is added. The new page should appear after the asynchronous call is complete.

### Actual behavior

The old page is removed as expected, but the new page content does not appear. Only the content.

### Workaround

The workaround is illustrated in commented-out code. Add a second page, set the selected index to that new page, and then remove it. Uncomment the code in MainPage.OnNavigatedTo() to see the expected behavior.

### Best guess

The content animates on when a new page is selected. My best guess is that this animation is not triggered on the new page content. The reason is that the pivot originally contained only one page; the selected index was 0. When it was removed, the selected index remained at 0. When the new page was added, the selected index was set to that new page, but alas, that is still 0. Because the selected index did not actually change, the animation was not started.