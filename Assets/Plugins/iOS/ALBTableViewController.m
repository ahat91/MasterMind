//
//  ALBTableViewController.m
//  Unity-iPhone
//
//  Created by Patrick Antoine on 5/10/14.
//
//

#import "ALBTableViewController.h"

@implementation ALBTableViewController
#pragma mark UIResponderCallbacks
- (void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event
{
    if([MHTools touchesBeganIsValid:[MHTools getKeyFromActual:self]])
        [ALBResponder touchesBegan:[MHTools getKeyFromActual:self] touches:touches withEvent:event];
    [super touchesBegan:touches withEvent:event];
}

- (void)touchesMoved:(NSSet *)touches withEvent:(UIEvent *)event
{
    if([MHTools touchesMovedIsValid:[MHTools getKeyFromActual:self]])
        [ALBResponder touchesMoved:[MHTools getKeyFromActual:self] touches:touches withEvent:event];
    [super touchesMoved:touches withEvent:event];
}

- (void)touchesEnded:(NSSet *)touches withEvent:(UIEvent *)event
{
    if([MHTools touchesEndedIsValid:[MHTools getKeyFromActual:self]])
        [ALBResponder touchesEnded:[MHTools getKeyFromActual:self] touches:touches withEvent:event];
    [super touchesEnded:touches withEvent:event];
}

- (void)touchesCancelled:(NSSet *)touches withEvent:(UIEvent *)event
{
    if([MHTools touchesCancelledIsValid:[MHTools getKeyFromActual:self]])
        [ALBResponder touchesCancelled:[MHTools getKeyFromActual:self] touches:touches withEvent:event];
    [super touchesCancelled:touches withEvent:event];
}

- (void)motionBegan:(UIEventSubtype)motion withEvent:(UIEvent *)event
{
    [ALBResponder motionBegan:[MHTools getKeyFromActual:self] motion:motion withEvent:event];
}

- (void)motionEnded:(UIEventSubtype)motion withEvent:(UIEvent *)event
{
    [ALBResponder motionEnded:[MHTools getKeyFromActual:self] motion:motion withEvent:event];
}

- (void)motionCancelled:(UIEventSubtype)motion withEvent:(UIEvent *)event
{
    [ALBResponder motionCancelled:[MHTools getKeyFromActual:self] motion:motion withEvent:event];
}

- (void)remoteControlReceivedWithEvent:(UIEvent *)event
{
    [ALBResponder remoteControlReceivedWithEvent:[MHTools getKeyFromActual:self] event:event];
}

#pragma mark BaseCallBacks
- (void)viewDidLoad
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewDidLoad:[MHTools getKeyFromActual:self]];
}
- (void)viewWillAppear:(BOOL)animated
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewWillAppear:[MHTools getKeyFromActual:self] animated:animated];
}
- (void)viewDidAppear:(BOOL)animated
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewDidAppear:[MHTools getKeyFromActual:self] animated:animated];
}
- (void)viewWillDisappear:(BOOL)animated
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewWillDisappear:[MHTools getKeyFromActual:self] animated:animated];
}
- (void)viewDidDisappear:(BOOL)animated
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewDidDisappear:[MHTools getKeyFromActual:self] animated:animated];
}
- (void)viewWillLayoutSubviews
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewWillLayoutSubviews:[MHTools getKeyFromActual:self]];
}
- (void)viewDidLayoutSubviews
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController viewDidLayoutSubviews:[MHTools getKeyFromActual:self]];
}
- (void)didReceiveMemoryWarning
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController didReceiveMemoryWarning:[MHTools getKeyFromActual:self]];
}
- (void)willRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController willRotateToInterfaceOrientation:[MHTools getKeyFromActual:self] orientation:toInterfaceOrientation duration:duration];
}
- (void)willAnimateRotationToInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation duration:(NSTimeInterval)duration
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController willAnimateRotationToInterfaceOrientation:[MHTools getKeyFromActual:self] orientation:interfaceOrientation duration:duration];
}
- (void)didRotateFromInterfaceOrientation:(UIInterfaceOrientation)fromInterfaceOrientation
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController didRotateFromInterfaceOrientation:[MHTools getKeyFromActual:self] orientation:fromInterfaceOrientation];
}
- (void)willMoveToParentViewController:(UIViewController *)parent
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController willMoveToParentViewController:[MHTools getKeyFromActual:self] parentViewController:parent];
}
- (void)didMoveToParentViewController:(UIViewController *)parent
{
    if(![MHTools actualObjectExistsByObject:self])
        return;
    [ALBViewController willMoveToParentViewController:[MHTools getKeyFromActual:self] parentViewController:parent];
}
@end
