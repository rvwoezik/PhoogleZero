import { PhoogleZeroPage } from './app.po';

describe('abp-zero-template App', function () {
    let page: PhoogleZeroPage;

    beforeEach(() => {
        page = new PhoogleZeroPage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        page.getCopyright().then(value => {
            expect(value).toEqual(new Date().getFullYear() + ' © PhoogleZero.');
        });
    });
});
